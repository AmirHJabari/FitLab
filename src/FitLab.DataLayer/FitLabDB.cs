using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using FitLab.DataLayer.Services;
using FitLab.DataLayer.Repositories;

namespace FitLab.DataLayer
{
    public class FitLabDB : IDisposable
    {
        private SQLiteConnection _db;

        private ICustomersRepository _customersRepository;
        private IGymRulesAndPropertiesRepository _gymRulesAndPropertiesRepository;
        private IGymTimesRepository _gymTimesRepository;
        private IGymServicesRepository _gymServicesRepository;
        private IServicesTransactionsRepository _servicesTransactionsRepository;

        public FitLabDB(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = @"Data Source=DataBase\FitLab_DB.db";
            }

            _db = new SQLiteConnection(connectionString);
        }

        public ICustomersRepository Customers
        {
            get
            {
                if (this._customersRepository == null)
                {
                    _customersRepository = new CustomersRepository(_db);
                }
                return _customersRepository;
            }
        }
        public IGymTimesRepository GymTimes
        {
            get
            {
                if (this._gymTimesRepository == null)
                {
                    _gymTimesRepository = new GymTimesRepository(_db);
                }
                return _gymTimesRepository;
            }
        }
        public IServicesTransactionsRepository ServicesTransactions
        {
            get
            {
                if (_servicesTransactionsRepository == null)
                {
                    _servicesTransactionsRepository = new ServicesTransactionsRepository(_db);
                }
                return _servicesTransactionsRepository;
            }
        }

        internal IGymServicesRepository GymServices
        {
            get
            {
                if (this._gymServicesRepository == null)
                {
                    this._gymServicesRepository = new GymServicesRepository(_db);
                }
                return this._gymServicesRepository;
            }
        }
        internal IGymRulesAndPropertiesRepository GymRulesAndProperties
        {
            get
            {
                if (this._gymRulesAndPropertiesRepository == null)
                {
                    _gymRulesAndPropertiesRepository = new GymRulesAndPropertiesRepository(_db);
                }
                return _gymRulesAndPropertiesRepository;
            }
        }


        public void Dispose()
        {
            _db.Close();
            _db.Dispose();
        }
    }
}
