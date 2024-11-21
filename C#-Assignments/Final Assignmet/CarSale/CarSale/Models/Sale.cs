using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Models
{
    [Serializable]
    public class Sale
    {
        private Car car;
        private Customer customer;
        private DateTime date;
        public Sale(Customer customer, Car car, DateTime date)
        {
            this.car = car;
            this.customer = customer;
            this.date = date;
        }

        public Car GetCar()
        {
            return this.car;
        }

        public Customer GetCustomer()
        {
           return this.customer;
        }

        public DateTime GetDate()
        {
            return this.date;
        }
    }

   
}
