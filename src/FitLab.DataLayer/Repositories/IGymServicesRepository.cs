using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitLab.DataLayer.Models;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Repositories
{
    public interface IGymServicesRepository
    {
        List<GymService> GetGymServices();
        bool UpdateProvidingState(int serviceID, bool isProviding);
    }
}
