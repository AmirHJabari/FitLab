using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using FitLab.DataLayer.Repositories;

namespace FitLab.DataLayer.Services
{
    public class ServicesTransactionsRepository : IServicesTransactionsRepository
    {
        private SQLiteConnection db;
        public ServicesTransactionsRepository(SQLiteConnection connection)
        {
            this.db = connection;
        }

        // returns that fields which are true (you need)
        public string GetFields(ServicesTransactionFields whichFields)
        {
            string fields = "ID";

            if (whichFields.CustomerID)
                fields += ", CustomerID";

            if (whichFields.Date)
                fields += ", Date";

            if (whichFields.Description)
                fields += ", Description";

            if (whichFields.Goodses)
                fields += ", Goodses";

            if (whichFields.IsPaid)
                fields += ", IsPaid";

            if (whichFields.PaidPrice)
                fields += ", PaidPrice";

            if (whichFields.Price)
                fields += ", Price";

            if (whichFields.ServiceID)
                fields += ", ServiceID";

            return fields;
        }


        // >> GymTimeFields whichFields = null
        //  Make true that fields you want.
        //  If whichFields be null it will fill all of fields :)
        public List<ServicesTransaction> GetAll(ServicesTransactionFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<ServicesTransaction> servicesTransactions;

            string query = $"SELECT {fields} FROM ServicesTransactions";
            servicesTransactions = db.Query<ServicesTransaction>(query).ToList();

            return servicesTransactions;
        }
        public async Task<List<ServicesTransaction>> GetAllAsync(ServicesTransactionFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                List<ServicesTransaction> servicesTransactions;

                string query = $"SELECT {fields} FROM ServicesTransactions";
                servicesTransactions = (await db.QueryAsync<ServicesTransaction>(query)).ToList();

                return servicesTransactions;
            });
        }

        public List<ServicesTransaction> Search(string customerID, ServicesTransactionFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<ServicesTransaction> servicesTransactions;

            string query = $"SELECT {fields} FROM ServicesTransactions WHERE CustomerID LIKE @customerID";
            servicesTransactions = db.Query<ServicesTransaction>(query, new { filter = customerID }).ToList();

            return servicesTransactions;
        }

        public async Task<List<ServicesTransaction>> SearchAsync(string customerID, ServicesTransactionFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);

                List<ServicesTransaction> servicesTransactions;

                string query = $"SELECT {fields} FROM ServicesTransactions WHERE CustomerID LIKE @customerID";
                servicesTransactions = (await db.QueryAsync<ServicesTransaction>(query, new { filter = customerID })).ToList();

                return servicesTransactions;
            });
        }


        public ServicesTransaction GetByID(int ID)
        {
            ServicesTransaction servicesTransactions;

            string query = "SELECT * FROM ServicesTransactions WHERE ID=@ID";
            servicesTransactions = db.Query<ServicesTransaction>(query, new { ID = ID }).FirstOrDefault();

            return servicesTransactions;
        }
        public bool Insert(ServicesTransaction obj)
        {
            try
            {
                string query = "INSERT INTO ServicesTransactions " +
                    "(CustomerID,  ServiceID,  Goodses,  Description, Date, Price, IsPaid, PaidPrice) " +
                    $"VALUES(@CustomerID, @ServiceID, @Goodses, @Description, \"{obj.Date:yyyy-MM-dd} {obj.Date.TimeOfDay:hh\\:mm\\:ss}\", @Price, @IsPaid, @PaidPrice)";

                db.Execute(query, obj);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(ServicesTransaction obj)
        {
            try
            {
                string query = "UPDATE ServicesTransactions SET" +
                    " CustomerID= @CustomerID, ServiceID = @ServiceID, Goodses = @Goodses, Description = @Description," +
                    $" Date = \"{obj.Date:yyyy-MM-dd} {obj.Date.TimeOfDay:hh\\:mm\\:ss}\", Price = @Price, IsPaid= @IsPaid, PaidPrice = @PaidPrice " +
                    "WHERE ID = @ID";

                db.Execute(query, obj);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(ServicesTransaction obj)
        {
            return Delete(obj.ID);
        }
        public bool Delete(int ID)
        {
            try
            {
                string query = "DELETE FROM ServicesTransactions WHERE ID = @ID";
                db.Execute(query, new { ID = ID });

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ChangeCustomer(int oldCustomerID, int newCustomerID)
        {
            try
            {
                string query = "UPDATE ServicesTransactions SET " +
                    $"CustomerID= @NewCustomerID WHERE CustomerID = @OldNewCustomerID";

                db.Execute(query, new { NewCustomerID = newCustomerID, OldNewCustomerID = oldCustomerID });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAllByCustomerID(int customerID)
        {
            try
            {
                string query = "DELETE FROM ServicesTransactions WHERE CustomerID = @CustomerID";
                db.Execute(query, new { CustomerID = customerID });

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<ServicesTransaction>> AdvancedSearchTransactionAsync(bool? isPaid = null, ServicesTransactionFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                string filter = "";
                List<ServicesTransaction> servicesTransactions;
                if (isPaid != null)
                    filter += $"WHERE IsPaid = {isPaid} ";


                string query = $"SELECT {fields} FROM ServicesTransactions " + filter;
                servicesTransactions = (await db.QueryAsync<ServicesTransaction>(query)).ToList();

                return servicesTransactions;
            });
        }
    }
}
