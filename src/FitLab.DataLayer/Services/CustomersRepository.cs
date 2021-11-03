using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLab.DataLayer.Repositories;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using System.Data.SQLite;
using Dapper;

namespace FitLab.DataLayer.Services
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly SQLiteConnection db;
        public CustomersRepository(SQLiteConnection connection)
        {
            this.db = connection;
        }

        // returns that fields which are true (you need)
        public string GetFields(CustomerFields whichFields)
        {
            string fields = "CustomerID";

            if (whichFields.BirthDate)
                fields += ", BirthDate";

            if (whichFields.Email)
                fields += ", Email";

            if (whichFields.FullName)
                fields += ", FullName";

            if (whichFields.MoreInfo)
                fields += ", MoreInfo";

            if (whichFields.PhoneNumber)
                fields += ", PhoneNumber";

            if (whichFields.SignDate)
                fields += ", SignDate";

            return fields;
        }


        // >> CustomerFields whichFields = null
        //  Make true that fields you want.
        //  If whichFields be null it will fill all of fields :)
        public List<Customer> GetAll(CustomerFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<Customer> customers;

            string query = $"SELECT {fields} FROM Customers";
            customers = db.Query<Customer>(query).ToList();

            if (whichFields != null && whichFields.Debt)
            {
                foreach (var c in customers)
                {
                    c.Debt = GetDebt(c.CustomerID);
                }
            }

            return customers;
        }
        public async Task<List<Customer>> GetAllAsync(CustomerFields whichFields = null)
        {
            return await Task.Run(async () =>
             {
                 string fields = (whichFields == null) ? "*" : GetFields(whichFields);

                 List<Customer> customers;

                 //System.Threading.Thread.Sleep(10000);
                 string query = $"SELECT {fields} FROM Customers";
                 customers = (await db.QueryAsync<Customer>(query)).ToList();

                 if (whichFields != null && whichFields.Debt)
                 {
                     foreach (var c in customers)
                     {
                         c.Debt = await GetDebtAsync(c.CustomerID);
                     }
                 }

                 return customers;
             });

        }

        public List<Customer> Search(string filter, CustomerFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<Customer> customers;

            string query = $"SELECT {fields} FROM Customers WHERE FullName LIKE @FullName or CustomerID LIKE @CustomerID";
            customers = db.Query<Customer>(query, new { FullName = $"%{filter}%", CustomerID = filter }).ToList();

            if (whichFields != null && whichFields.Debt)
            {
                foreach (var c in customers)
                {
                    c.Debt = GetDebt(c.CustomerID);
                }
            }

            return customers;
        }

        public async Task<List<Customer>> SearchAsync(string filter, CustomerFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);

                List<Customer> customers;

                string query = $"SELECT {fields} FROM Customers WHERE FullName LIKE @FullName or CustomerID LIKE @CustomerID";
                customers = (await db.QueryAsync<Customer>(query, new { FullName = $"%{filter}%", CustomerID = filter })).ToList();

                if (whichFields != null && whichFields.Debt)
                {
                    foreach (var c in customers)
                    {
                        c.Debt = await GetDebtAsync(c.CustomerID);
                    }
                }

                return customers;
            });
        }


        public bool HasGymTime(int customerID)
        {
            string query = "SELECT count() FROM GymTimes WHERE CustomerID = @CustomerID";
            return db.ExecuteScalar<bool>(query, new { CustomerID = customerID });
        }
        public bool HasTransaction(int customerID)
        {
            string query = "SELECT count() FROM ServicesTransactions WHERE CustomerID = @CustomerID";
            return db.ExecuteScalar<bool>(query, new { CustomerID = customerID });
        }

        public Customer GetByID(int ID)
        {
            Customer customer;
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            customer = db.Query<Customer>(query, new { CustomerID = ID }).FirstOrDefault();

            customer.Debt = GetDebt(customer.CustomerID);

            return customer;
        }
        public string GetNameByID(int customerID)
        {
            string query = "SELECT FullName FROM Customers WHERE CustomerID = @CustomerID";

            return db.Query<string>(query, new { CustomerID = customerID }).FirstOrDefault();
        }
        public bool Delete(Customer obj)
        {
            return Delete(obj.CustomerID);
        }
        public bool Delete(int ID)
        {
            try
            {
                string query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                db.Execute(query, new { CustomerID = ID });

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(Customer obj)
        {
            try
            {
                string query = "INSERT INTO Customers " +
                           "(FullName,  PhoneNumber,  Email, BirthDate, SignDate, MoreInfo) " +
                    $"VALUES(@FullName, @PhoneNumber, @Email, \"{obj.BirthDate.ToString("yyyy-MM-dd")}\", \"{obj.SignDate.ToString("yyyy-MM-dd")}\", @MoreInfo)";
                db.Execute(query, obj);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Customer obj)
        {
            try
            {
                string query = "UPDATE Customers SET FullName= @FullName, PhoneNumber = @PhoneNumber, Email = @Email," +
                    $" BirthDate = \"{obj.BirthDate.ToString("yyyy-MM-dd")}\", SignDate = \"{obj.SignDate.ToString("yyyy-MM-dd")}\", MoreInfo= @MoreInfo" +
                    $" WHERE CustomerID = @CustomerID";
                db.Execute(query, obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<long> GetDebtAsync(int customerID)
        {
            return await Task.Run(async () =>
            {
                long debt;
                string query = $"SELECT Price - PaidPrice FROM GymTimes WHERE IsOpen = 0 AND IsPaid = 0 AND CustomerID = {customerID}";
                long timesDebt = (await db.QueryAsync<long>(query)).Sum();

                query = $"SELECT Price - PaidPrice FROM ServicesTransactions WHERE IsPaid = 0 AND CustomerID = {customerID}";
                long transactionsDebt = (await db.QueryAsync<long>(query)).Sum();
                debt = Math.Max(timesDebt + transactionsDebt, 0);

                return debt;
            });
        }

        public long GetDebt(int customerID)
        {
            long debt;
            string query = $"SELECT Price - PaidPrice FROM GymTimes WHERE IsOpen = 0 AND IsPaid = 0 AND CustomerID = {customerID}";
            long timesDebt = db.Query<long>(query).Sum();

            query = $"SELECT Price - PaidPrice FROM ServicesTransactions WHERE IsPaid = 0 AND CustomerID = {customerID}";
            long transactionsDebt = db.Query<long>(query).Sum();
            debt = Math.Max(timesDebt + transactionsDebt, 0);

            return debt;
        }
    }
}
