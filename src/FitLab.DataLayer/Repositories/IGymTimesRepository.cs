using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Repositories
{
    public interface IGymTimesRepository : ICRUDRepository<GymTime, GymTimeFields>
    {
        Task<List<GymTime>> GetOpenTimesAsync(GymTimeFields whichFields = null);
        Task<List<GymTime>> GetCloseTimesAsync(GymTimeFields whichFields = null);
        bool ChangeCustomer(int oldCustomerID, int newCustomerID);
        bool DeleteAllByCustomerID(int customerID);
        Task<List<GymTime>> AdvancedSearchTimesAsync(bool isOpen, bool? isPaid = null, GymTimeFields whichFields = null);
    }
}
