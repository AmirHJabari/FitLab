using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Repositories
{
    public interface IServicesTransactionsRepository : ICRUDRepository<ServicesTransaction, ServicesTransactionFields>
    {
        bool ChangeCustomer(int oldCustomerID, int newCustomerID);
        bool DeleteAllByCustomerID(int customerID);
        Task<List<ServicesTransaction>> AdvancedSearchTransactionAsync(bool? isPaid = null, ServicesTransactionFields whichFields = null);
    }
}
