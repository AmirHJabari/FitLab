using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLab.DataLayer.Models;

namespace FitLab.DataLayer.Repositories
{
    public interface IGymRulesAndPropertiesRepository
    {
        GymRulesAndProperties GetGymRulesAndProperties();
        bool UpdateGymRulesAndProperties(GymRulesAndProperties gymRulesAndProperties);
    }
}
