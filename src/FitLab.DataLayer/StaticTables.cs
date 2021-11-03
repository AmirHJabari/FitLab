using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLab.DataLayer.Models;

namespace FitLab.DataLayer
{
    public static class StaticTables
    {
        private static GymRulesAndProperties _gymRulesAndProperties;
        private static List<GymService> _gymServices;


        // GymServices Table
        public static List<GymService> GymServices
        {
            get
            {
                if (_gymServices == null)
                {
                    FillGymServices();
                }
                return _gymServices;
            }
        }
        private static void FillGymServices()
        {
            using (FitLabDB db = new FitLabDB())
                _gymServices = db.GymServices.GetGymServices();
        }
        public static bool UpdateServiceProvidingState(int serviceID, bool isProviding)
        {
            bool resualt;
            using (FitLabDB db = new FitLabDB())
            {
                resualt = db.GymServices.UpdateProvidingState(serviceID,isProviding);
            }
            FillGymServices();
            return resualt;
        }


        // GymRulesAndProperties Table
        public static GymRulesAndProperties GymRulesAndProperties
        {
            get
            {
                if (_gymRulesAndProperties == null)
                {
                    FillGymRulesAndProperties();
                }
                return _gymRulesAndProperties;
            }
        }
        private static void FillGymRulesAndProperties()
        {
            using (FitLabDB db = new FitLabDB())
                _gymRulesAndProperties = db.GymRulesAndProperties.GetGymRulesAndProperties();
        }
        public static bool UpdateGymRulesAndProperties(GymRulesAndProperties obj)
        {
            bool resualt;
            using (FitLabDB db = new FitLabDB())
            {
                resualt = db.GymRulesAndProperties.UpdateGymRulesAndProperties(obj);
            }
            FillGymRulesAndProperties();
            return resualt;
        }
    }
}
