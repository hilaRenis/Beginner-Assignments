using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3_SnackBar_week12
{
    public class Snack
    {
        private string name;
        private double price;
        private int stockAmount;

        public Snack(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.stockAmount = amount;
        }

        public bool DecreaseStock(int amount)
        {
            if (stockAmount >= amount)
            {
                stockAmount = stockAmount - amount;
                return true;
            }
            return false;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetAmountInStock()
        {
            return stockAmount;
        }
    }
}
