using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Models
{
    [Serializable]
    public class Car
    {
        private string brand;
        private string model;
        private int price;
        private int yearProduce;

        public int id
        {
            get;
            set;
        }

        public Car(string brand, string model, int price, int yearProduce, int id)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.yearProduce = yearProduce;
        }
        public Car(string brand, string model, int price, int yearProduce)
        {
            this.id = 0;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.yearProduce = yearProduce;
        }
        public int GetID()
        {
            return this.id;
        }

        public string GetBrand()
        {
            return this.brand;
        }

        public string GetModel()
        {
            return this.model;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public int GetProduceYear()
        {
            return this.yearProduce;
        }
    }
}
