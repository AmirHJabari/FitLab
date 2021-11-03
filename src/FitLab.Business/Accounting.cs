using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitLab.DataLayer.Models;
using FitLab.DataLayer.Models.SelectedFields;
using FitLab.DataLayer.Services;
using FitLab.DataLayer;
using FitLab.Utilities;


namespace FitLab.Business
{
    public static class Accounting
    {
        public async static Task<long> GetTodayCashAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t=> t.DateAndTime.Date == DateTime.Now.Date).ToList();
            transactions = transactions.Where(t=> t.Date.Date == DateTime.Now.Date).ToList();

            timesCash = times.Select(t=> t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t=> t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetTodayDemandAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date == DateTime.Now.Date).ToList();
            transactions = transactions.Where(t => t.Date.Date == DateTime.Now.Date).ToList();

            timesCash = times.Select(t => t.Price - t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.Price - t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetTodayTotalAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date == DateTime.Now.Date).ToList();
            transactions = transactions.Where(t => t.Date.Date == DateTime.Now.Date).ToList();

            timesCash = times.Select(t => t.Price).Sum();
            transactionsCash = transactions.Select(t => t.Price).Sum();

            return timesCash + transactionsCash;
        }

        public async static Task<long> GetThisWeekCashAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();

            timesCash = times.Select(t => t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetThisWeekDemandAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();

            timesCash = times.Select(t => t.Price - t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.Price - t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetThisWeekTotalAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-(DateTime.Now.PersianDayOfWeek() + 1))).ToList();

            timesCash = times.Select(t => t.Price).Sum();
            transactionsCash = transactions.Select(t => t.Price).Sum();

            return timesCash + transactionsCash;
        }


        public async static Task<long> GetThisMonthCashAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();

            timesCash = times.Select(t => t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetThisMonthDemandAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();

            timesCash = times.Select(t => t.Price - t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.Price - t.PaidPrice).Sum();

            return timesCash + transactionsCash;

        }
        public async static Task<long> GetThisMonthTotalAsync()
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();
            transactions = transactions.Where(t => t.Date.Date >= DateTime.Now.AddDays(-DateTime.Now.PersianDayOfMonth())).ToList();

            timesCash = times.Select(t => t.Price).Sum();
            transactionsCash = transactions.Select(t => t.Price).Sum();

            return timesCash + transactionsCash;
        }

        public async static Task<long> GetCashAsync(DateTime start, DateTime end)
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= start && t.DateAndTime.Date <= end).ToList();
            transactions = transactions.Where(t => t.Date.Date >= start && t.Date.Date <= end).ToList();

            timesCash = times.Select(t => t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.PaidPrice).Sum();

            return timesCash + transactionsCash;
        }
        public async static Task<long> GetDemandAsync(DateTime start, DateTime end)
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= start && t.DateAndTime.Date <= end).ToList();
            transactions = transactions.Where(t => t.Date.Date >= start && t.Date.Date <= end).ToList();

            timesCash = times.Select(t => t.Price - t.PaidPrice).Sum();
            transactionsCash = transactions.Select(t => t.Price - t.PaidPrice).Sum();

            return timesCash + transactionsCash;

        }
        public async static Task<long> GetTotalAsync(DateTime start, DateTime end)
        {
            long timesCash;
            long transactionsCash;

            GymTimeFields timeFields = new GymTimeFields()
            {
                PaidPrice = true,
                Price = true,
                DateAndTime = true
            };
            List<GymTime> times;

            ServicesTransactionFields transactionFields = new ServicesTransactionFields()
            {
                PaidPrice = true,
                Price = true,
                Date = true
            };
            List<ServicesTransaction> transactions;

            using (FitLabDB db = new FitLabDB())
            {
                times = await db.GymTimes.AdvancedSearchTimesAsync(isOpen: false, whichFields: timeFields);
                transactions = await db.ServicesTransactions.GetAllAsync(transactionFields);
            }

            times = times.Where(t => t.DateAndTime.Date >= start && t.DateAndTime.Date <= end).ToList();
            transactions = transactions.Where(t => t.Date.Date >= start && t.Date.Date <= end).ToList();

            timesCash = times.Select(t => t.Price).Sum();
            transactionsCash = transactions.Select(t => t.Price).Sum();

            return timesCash + transactionsCash;

        }
    }
}
