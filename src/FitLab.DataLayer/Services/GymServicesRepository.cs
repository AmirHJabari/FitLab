using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Repositories;
using System.Data;

namespace FitLab.DataLayer.Services
{
    public class GymServicesRepository : IGymServicesRepository
    {
        private SQLiteConnection db;
        public GymServicesRepository(SQLiteConnection connection)
        {
            this.db = connection;
        }

        public List<GymService> GetGymServices()
        {
            string query = "SELECT * FROM GymServices";
            return db.Query<GymService>(query).ToList();

        }

        public bool UpdateProvidingState(int serviceID, bool isProviding)
        {
            try
            {
                string query = $"UPDATE GymServices SET IsProviding = {isProviding} WHERE ServiceID = {serviceID}";
                db.Execute(query);
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
