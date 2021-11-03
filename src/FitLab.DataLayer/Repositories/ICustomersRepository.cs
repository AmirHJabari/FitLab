using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Repositories
{
    public  interface ICustomersRepository : ICRUDRepository<Customer,CustomerFields>
    {
        bool HasGymTime(int customerID);
        Task<long> GetDebtAsync(int customerID);
        long GetDebt(int customerID);
        bool HasTransaction(int customerID);
        string GetNameByID(int customerID);
    }
}
