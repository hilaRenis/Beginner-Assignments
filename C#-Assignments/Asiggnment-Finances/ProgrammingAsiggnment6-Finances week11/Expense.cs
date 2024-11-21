using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAsiggnment6_Finances_week11
{
    public class Expense
    {
        private string name;
        private double amount;

        public Expense(string name, double amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public double GetAmount()
        {
            return this.amount;
        }

        public string GetInfo()
        {
            return name + "-" + amount;
        }
    }
}
