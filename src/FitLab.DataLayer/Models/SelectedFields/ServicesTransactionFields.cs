using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Models.SelectedFields
{
    public class ServicesTransactionFields
    {
        public bool CustomerID { get; set; }
        public bool ServiceID { get; set; }
        public bool Goodses { get; set; }
        public bool Description { get; set; }
        public bool Date { get; set; }
        public bool Price { get; set; }
        public bool IsPaid { get; set; }
        public bool PaidPrice { get; set; }
    }
}
