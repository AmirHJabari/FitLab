using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Models
{
    public class ServicesTransaction
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ServiceID { get; set; }
        public string Goodses { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long Price { get; set; }
        public long PaidPrice { get; set; }
        public bool IsPaid { get; set; }

        //public virtual Customer Customers { get; set; }
        //public virtual GymService GymServices { get; set; }
    }
}
