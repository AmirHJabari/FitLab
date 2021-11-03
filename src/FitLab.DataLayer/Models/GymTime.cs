using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FitLab.DataLayer.Models
{
    public class GymTime
    {
        public int ID { get; }
        public int CustomerID { get; set; }
        public DateTime DateAndTime { get; set; }
        public DateTime Length { get; set; }
        public string BoxCode { get; set; }
        public bool IsOpen { get; set; }
        public long Price { get; set; }
        public bool IsPaid { get; set; }
        public long PaidPrice { get; set; }
        public string Description { get; set; }

        //public virtual Customer Customer { get; set; }
    }
}
