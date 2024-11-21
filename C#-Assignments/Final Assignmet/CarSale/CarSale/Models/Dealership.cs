using CarSale.Models;
using System;
using System.Collections.Generic;

namespace CarSale.Models
{
    [Serializable]
    public class Dealership
    {
        private List<Customer> customers = new List<Customer>();
        private CarInventory catalog = new CarInventory();
        private List<Sale> sales = new List<Sale>();
        public Dealership()
        {
            this.catalog = null;
        }
        public void loadCustomer(List<Customer> customers)
        {
            this.customers = customers;
        }
        public void loadCatalog(CarInventory catalog)
        {
            this.catalog = catalog;
        }

        public void loadSales(List<Sale> sales)
        {
            this.sales = sales;
        }

        public void addCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void saleCarToCustomer(Customer customer, Car car)
        {
            Sale sale = new Sale(customer, car, DateTime.Now);
            sales.Add(sale);
            catalog.RemoveCarInventory(car);
        }

        public List<Customer> getCustomers()
        {
            return this.customers;
        }
      
        public List<Sale> getSales()
        {
            sales.Sort((p, q) => p.GetDate().CompareTo(q.GetDate()));

            return sales;
        }

        public CarInventory GetCarInventory()
        {
            return this.catalog;
        }

        public int getCustomerNextId()
        {
            int id = 0;
            foreach (Customer customer in this.customers)
            {
                if (id < customer.id)
                {
                    id = customer.id;
                }
            }

            return id + 1;
        }
    }
}
