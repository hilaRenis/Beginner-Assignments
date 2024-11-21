using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment3_SnackBar_week12
{
    public class SnackBar
    {
        public Snack snack1;
        public Snack snack2;
        public Snack snack3;

        private double totalrevenue;

        public SnackBar()
        {
            this.snack1 = new Snack("Tost", 5.50, 10);
            this.snack2 = new Snack("Croissant", 3.00, 15);
            this.snack3 = new Snack("Cheesecake", 7.50, 5);
            this.totalrevenue = 0;
        }


        public double ProcessOrder(int snack1_order, int snack2_order, int snack3_order)
        {
            if (snack1.GetAmountInStock() >= snack1_order && snack2.GetAmountInStock() >= snack2_order && snack3.GetAmountInStock() >= snack3_order)
            {
                snack1.DecreaseStock(snack1_order);
                snack2.DecreaseStock(snack2_order);
                snack3.DecreaseStock(snack3_order);

                totalrevenue = totalrevenue + (snack1_order * snack1.GetPrice() + snack2_order * snack2.GetPrice() + snack3_order * snack3.GetPrice());
                return totalrevenue;
            }
            else
            {
                return -1;
            }

        }

        public double GetRevenue()
        {
            return totalrevenue;
        }
    }
}
