using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Models
{
    [Serializable]
    public class Customer
    {
        private string customerName;
        private string customerAddress;
        private string customerZipCode;
        private string customerCity;
        private string customerPhoneNo;

        public int id
        {
            get;
            set;
        }

        public Customer(string customerName, string customerAddress,   string customerPhoneNo, string customerZipCode, string customerCity)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerZipCode = customerZipCode;
            this.customerPhoneNo = customerPhoneNo;
            this.customerCity = customerCity;
        }

        public string GetCustomerName()
        {
            return this.customerName;
        }

        public string GetCustomerAddress()
        {
            return this.customerAddress;
        }

        public string GetCustomerZipCode()
        {
            return this.customerZipCode;
        }
        public string GetCustomerCity()
        {
            return this.customerCity;
        }


        public string GetCustomerPhoneNo()
        {
            return this.customerPhoneNo;
        }
    }
}
