using Dapper;
using FitLab.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Services
{
    public class GymRulesAndPropertiesRepository : DataLayer.Repositories.IGymRulesAndPropertiesRepository
    {
        private SQLiteConnection db;
        public GymRulesAndPropertiesRepository(SQLiteConnection connection)
        {
            this.db = connection;
        }

        public GymRulesAndProperties GetGymRulesAndProperties()
        {
            string query = "SELECT * FROM GymRulesAndProperties";
            return db.Query<GymRulesAndProperties>(query).FirstOrDefault();
        }

        public bool UpdateGymRulesAndProperties(GymRulesAndProperties obj)
        {
            try
            {
                string query = "UPDATE GymRulesAndProperties SET" +
                    " GymName= @GymName, OwnerName = @OwnerName, DefaultPriceForGymTime = @DefaultPriceForGymTime";
                db.Execute(query, obj);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
