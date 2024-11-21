using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Sandwich
    {
        private string name;
        private double basePrice;
        private BreadType bread;

        private List<Ingredient> ingredients;

        public Sandwich(string name, BreadType bread, double basePrice)
        {
            this.name = name;
            this.bread = bread;
            this.basePrice = basePrice;

            this.ingredients = new List<Ingredient>();
        }

        public string GetName()
        { return this.name; }

        public BreadType GetBread()
        { return this.bread; }


        public void AddIngredient(Ingredient i)
        {
            if (!this.ingredients.Any(item => item.GetName() == i.GetName()))
            {
                if (this.ingredients.Count <= 5)
                {
                    this.ingredients.Add(i);
                }
            }
        }

        public string GetInfo()
        {
            string i_list = "";
            foreach(Ingredient i in ingredients)
            {
                i_list = i_list + i.GetName() + ", ";
            }
            
            
            return $"{this.name} ({this.bread} with {i_list.ToString()})";
        }

        public double GetPrice()
        {
            double total_price = this.basePrice;
            
            foreach(Ingredient i in this.ingredients)
            {
                total_price = total_price + i.GetPrice();
            }
            
            return total_price;
        }

        public double GetBasePrice()
        {
            double total_price = this.basePrice;

            return total_price;
        }
    }
}
