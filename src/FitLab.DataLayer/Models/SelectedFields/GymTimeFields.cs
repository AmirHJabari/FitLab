using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Models.SelectedFields
{
    public class GymTimeFields
    {
        public bool CustomerID { get; set; }
        public bool DateAndTime { get; set; }
        public bool Length { get; set; }
        public bool BoxCode { get; set; }
        public bool IsOpen { get; set; }
        public bool Price { get; set; }
        public bool IsPaid { get; set; }
        public bool PaidPrice { get; set; }
        public bool Description { get; set; }
    }
}
