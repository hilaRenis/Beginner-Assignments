using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    [Serializable]
    public class Bakery
    {
        private string name;
        private double VAT_PERCENTAGE;
        
        private List<Ingredient> available_ingredients;
        private List<Sandwich> offered_sandwiches;

        private List<Sandwich> sold_sandwiches;



        private Ingredient i;

        public Bakery(string name)
        {
            this.name = name;
            this.VAT_PERCENTAGE = 9;
            this.sold_sandwiches = new List<Sandwich>();

            this.available_ingredients = new List<Ingredient>();
            this.offered_sandwiches = new List<Sandwich>();

            this.available_ingredients.Add(new Ingredient("Cucumber", 0.05));
            this.available_ingredients.Add(new Ingredient("Tomato", 0.15));
            this.available_ingredients.Add(new Ingredient("Cheddar", 0.2));
            this.available_ingredients.Add(new Ingredient("Ham", 0.15));
            this.available_ingredients.Add(new Ingredient("Chorizo", 0.25));
            this.available_ingredients.Add(new Ingredient("Apple", 0.1));
            this.available_ingredients.Add(new Ingredient("Tuna", 0.2));
            this.available_ingredients.Add(new Ingredient("Smoked Salmon", 0.4));
            this.available_ingredients.Add(new Ingredient("Cream cheese", 0.15));
            this.available_ingredients.Add(new Ingredient("Gouda cheese", 0.1));

        }

        public string GetName()
        { return this.name; }

        public Ingredient[] GetAvailableIngredients()
        {
            return this.available_ingredients.ToArray();
        }

        public void AddSandwich(string name, BreadType bread, double base_price)
        {
            this.offered_sandwiches.Add(new Sandwich(name, bread, base_price));
        }

        public Sandwich[] GetAvailableSandwiches()
        {
            return this.offered_sandwiches.ToArray();
        }

        public Sandwich[] GetAvailableSandwiches(BreadType bread)
        {
            List<Sandwich> foundSandwiches = new List<Sandwich>();
            foreach (Sandwich s in this.offered_sandwiches)
            {
                if (bread == s.GetBread())
                { foundSandwiches.Add(s); }
            }
            return foundSandwiches.ToArray();
        }

        public double SellSandwich(Sandwich sold)
        {
            this.sold_sandwiches.Add(sold);

            double total_price = sold.GetPrice();


            return total_price*(1 + (this.VAT_PERCENTAGE/100));
        }

        public double CalculateRevenue(Boolean withVAT)
        {
            double total_revenue = 0;

            foreach(Sandwich s in this.sold_sandwiches)
            {
                total_revenue = total_revenue + s.GetPrice();
            }

            if (withVAT)
            {
                return total_revenue * (1 + (VAT_PERCENTAGE / 100));
            }
            else
            {
                return total_revenue;
            }
        }

    }
}
