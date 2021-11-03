using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.Utilities
{
    public static class MyConverter
    {
        public static DateTime ToGregorianDate(string persianDate)
        {
            try
            {
                int[] date = persianDate.Split('-').Select(d => Convert.ToInt32(d)).ToArray();

                return new DateTime(date[0], date[1], date[2], new PersianCalendar());
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
