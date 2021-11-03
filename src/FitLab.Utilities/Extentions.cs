
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace FitLab.Utilities
{
    public static class Extentions
    {
        //public static Gender ToGender(this string strGender)
        //{
        //    if (strGender.ToLower() == "female")
        //    {
        //        return Gender.Female;
        //    }
        //    else if (strGender.ToLower() == "male")
        //    {
        //        return Gender.Male;
        //    }
        //    else
        //    {
        //        return Gender.None;
        //    }
        //}
        public static string ToShamsi(this DateTime dateTime)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                string date = $"{pc.GetYear(dateTime).ToString("0000")}-{pc.GetMonth(dateTime).ToString("00")}-{pc.GetDayOfMonth(dateTime).ToString("00")}";
                return date;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static string Separate(this long number)
        {
            if (number > 10)
                return number.ToString("0,0");
            else
                return number.ToString();
        }
        public static string ReturnEmptyIfItsNull(this object str)
        {
            return (str == null) ? "" : (string)str.ToString(); 
        }
        public static string GetTime(this DateTime dateTime)
        {
            return $"{dateTime.Hour.ToString("00")}:{dateTime.Minute.ToString("00")}:{dateTime.Second.ToString("00")}";
        }

        public static int PersianDayOfWeek(this DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return 1;
                    
                case DayOfWeek.Monday:
                    return 2;
                    
                case DayOfWeek.Tuesday:
                    return 3;
                    
                case DayOfWeek.Wednesday:
                    return 4;
                    
                case DayOfWeek.Thursday:
                    return 5;
                    
                case DayOfWeek.Friday:
                    return 6;
                    
                case DayOfWeek.Saturday:
                    return 0;

                default:
                    return 6;
            }
            
        }

        public static int PersianDayOfMonth(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfMonth(dateTime);
        }

        public static int PersianMonth(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetMonth(dateTime);
        }
        public static int PersianYear(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(dateTime);
        }
    }
}
