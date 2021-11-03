
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitLab.DataLayer.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SignDate { get; set; }
        public string MoreInfo { get; set; }
        public long Debt { get; set; }

        #region Clone
        //public Customer Clone()
        //{
        //    Customer customer = new Customer()
        //    {
        //        FullName = this.FullName,
        //        DateOfBirth = this.DateOfBirth,
        //        SignDate = this.SignDate,
        //        Email = this.Email,
        //        Gender = this.Gender,
        //        MoreInfo = this.MoreInfo,
        //        PhoneNumber = this.PhoneNumber
        //    };
        //    return customer;
        //}
        #endregion

        #region Cast to CustomerView
        //public static implicit operator Customer(CustomerView customerView)
        //{
        //    Customer customer = new Customer()
        //    {
        //        BirthDate = customerView.BirthDate,
        //        CustomerID = customerView.CustomerID,
        //        Debt = customerView.Debt,
        //        Email = customerView.Email,
        //        FullName = customerView.FullName,
        //        Gender = customerView.Gender,
        //        MoreInfo =customerView.MoreInfo,
        //        PhoneNumber = customerView.PhoneNumber,
        //        SignDate = customerView.SignDate
        //    };
        //    return customer;
        //}
        #endregion

        //public virtual ICollection<GymTime> GymTimes { get; set; }
        //public virtual ICollection<ServicesTransaction> ServicesTransactions { get; set; }

        public override string ToString()
        {
            return $">> CustomerID: {this.CustomerID} \t\t FullName: {this.FullName} \t\t PhoneNumber: {this.PhoneNumber} \t\t Email: {this.Email} \t\t DateOfBirth: {this.BirthDate.ToString()} \t\t SignDate:{this.SignDate.ToString()} \t\t MoreInfo: {this.MoreInfo}";
        }
    }
}
