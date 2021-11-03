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
    public class GymTimesRepository : IGymTimesRepository
    {
        private SQLiteConnection db;
        public GymTimesRepository(SQLiteConnection connection)
        {
            this.db = connection;
        }

        // returns that fields which are true (you need)
        public string GetFields(GymTimeFields whichFields)
        {
            string fields = "ID";

            if (whichFields.BoxCode)
                fields += ", BoxCode";

            if (whichFields.CustomerID)
                fields += ", CustomerID";

            if (whichFields.DateAndTime)
                fields += ", DateAndTime";

            if (whichFields.Description)
                fields += ", Description";

            if (whichFields.IsOpen)
                fields += ", IsOpen";

            if (whichFields.IsPaid)
                fields += ", IsPaid";

            if (whichFields.Length)
                fields += ", Length";

            if (whichFields.PaidPrice)
                fields += ", PaidPrice";

            if (whichFields.Price)
                fields += ", Price";

            return fields;
        }


        // >> GymTimeFields whichFields = null
        //  Make true that fields you want.
        //  If whichFields be null it will fill all of fields :)
        public List<GymTime> GetAll(GymTimeFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<GymTime> gymTimes;
            string query = $"SELECT {fields} FROM GymTimes";
            gymTimes = db.Query<GymTime>(query).ToList();
            return gymTimes;
        }

        public async Task<List<GymTime>> GetAllAsync(GymTimeFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                
                List<GymTime> gymTimes;
                string query = $"SELECT {fields} FROM GymTimes";

                gymTimes = (await db.QueryAsync<GymTime>(query)).ToList();
                return gymTimes;
            });
        }



        public async Task<List<GymTime>> GetOpenTimesAsync(GymTimeFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                
                List<GymTime> gymTimes;

                string query = $"SELECT {fields} FROM GymTimes WHERE IsOpen > 0";

                gymTimes = (await db.QueryAsync<GymTime>(query)).ToList();
                return gymTimes;
            });
        }
        public async Task<List<GymTime>> GetCloseTimesAsync(GymTimeFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                
                List<GymTime> gymTimes;

                string query = $"SELECT {fields} FROM GymTimes WHERE IsOpen = 0";

                gymTimes = (await db.QueryAsync<GymTime>(query)).ToList();
                return gymTimes;
            });
        }


        public async Task<List<GymTime>> AdvancedSearchTimesAsync(bool isOpen, bool? isPaid = null, GymTimeFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);
                string filter = "";
                List<GymTime> gymTimes;

                if (isPaid != null)
                    filter += $" AND IsPaid = {isPaid} ";

                string query = $"SELECT {fields} FROM GymTimes WHERE IsOpen = {isOpen} " + filter;

                gymTimes = (await db.QueryAsync<GymTime>(query)).ToList();
                return gymTimes;
            });
        }

        public List<GymTime> Search(string customerID, GymTimeFields whichFields = null)
        {
            string fields = (whichFields == null) ? "*" : GetFields(whichFields);

            List<GymTime> gymTimes;

            string query = $"SELECT {fields} FROM GymTimes WHERE CustomerID LIKE @customerID";
            gymTimes = db.Query<GymTime>(query, new { filter = customerID }).ToList();

            return gymTimes;
        }

        public async Task<List<GymTime>> SearchAsync(string customerID, GymTimeFields whichFields = null)
        {
            return await Task.Run(async () =>
            {
                string fields = (whichFields == null) ? "*" : GetFields(whichFields);

                List<GymTime> gymTimes;
                string query = $"SELECT {fields} FROM GymTimes WHERE CustomerID LIKE @customerID";
                gymTimes = (await db.QueryAsync<GymTime>(query, new { filter = customerID })).ToList();

                return gymTimes;
            });
        }

        public GymTime GetByID(int ID)
        {
            GymTime gymTime;
            string query = "SELECT * FROM GymTimes WHERE ID = @ID";
            gymTime = db.Query<GymTime>(query, new { ID = ID }).FirstOrDefault();
            return gymTime;
        }
        public bool Delete(GymTime obj)
        {
            return Delete(obj.CustomerID);
        }
        public bool Delete(int ID)
        {
            try
            {
                string query = "DELETE FROM GymTimes WHERE ID = @ID";
                db.Execute(query, new { ID = ID });
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(GymTime obj)
        {
            try
            {
                string query = "INSERT INTO GymTimes " +
                   "(CustomerID, DateAndTime, Length, BoxCode, IsOpen, Price, IsPaid, PaidPrice, Description) " +
                    $"VALUES(@CustomerID, \"{obj.DateAndTime:yyyy-MM-dd} {obj.DateAndTime.TimeOfDay:hh\\:mm\\:ss}\", \"{obj.Length.TimeOfDay:hh\\:mm\\:ss}\", @BoxCode, @IsOpen, @Price, @IsPaid, @PaidPrice, @Description)";
                db.Execute(query, obj);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(GymTime obj)
        {
            try
            {
                string query = "UPDATE GymTimes SET " +
                    $"CustomerID= @CustomerID, DateAndTime = \"{obj.DateAndTime:yyyy-MM-dd} {obj.DateAndTime.TimeOfDay:hh\\:mm\\:ss}\", Length = \"{obj.Length.TimeOfDay:hh\\:mm\\:ss}\"," +
                    $" BoxCode = @BoxCode, IsOpen = @IsOpen, Price = @Price, IsPaid= @IsPaid, PaidPrice = @PaidPrice, Description = @Description " +
                    "WHERE ID = @ID";

                db.Execute(query, obj);
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
                string query = "UPDATE GymTimes SET " +
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
                string query = "DELETE FROM GymTimes WHERE CustomerID = @CustomerID";

                db.Execute(query, new { CustomerID = customerID });

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
