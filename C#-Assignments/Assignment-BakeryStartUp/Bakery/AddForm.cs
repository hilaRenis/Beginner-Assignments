using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {


        private string sandwich_name;
        private double total_price;
        private Ingredient[] i;

        private Bakery bakery_service;

        public AddForm(Bakery b)
        {
            InitializeComponent();

            this.cbbBreadFilter.DataSource = Enum.GetValues(typeof(BreadType));

            this.bakery_service = b;

            this.sandwich_name = this.tbxName.Text;
            this.total_price = double.Parse(this.textBox1.Text);
            this.label6.Text = this.total_price.ToString();

            if (bakery_service.GetAvailableIngredients().Length > 0)
            {
                this.i = bakery_service.GetAvailableIngredients();
                this.listBox1.Items.Clear();
                //this.listBox1.Items.AddRange(i);
                foreach (Ingredient a in i)
                {
                    this.listBox1.Items.Add($"{a.GetName().ToString()}, {a.GetPrice().ToString()}");
                    
                }
                //this.listBox1.MultiColumn = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.total_price = double.Parse(this.textBox1.Text);

            foreach(int o in listBox1.SelectedIndices)
            {
                this.total_price = this.total_price + i[o].GetPrice();
            }

            this.label6.Text = this.total_price.ToString();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.total_price = double.Parse(this.textBox1.Text);

            foreach (int o in listBox1.SelectedIndices)
            {
                this.total_price = this.total_price + i[o].GetPrice();
            }

            this.label6.Text = this.total_price.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(this.tbxName.Text) || String.IsNullOrEmpty(this.textBox1.Text)) || double.Parse(this.textBox1.Text)>0)
            {
                BreadType _bread = (BreadType)cbbBreadFilter.SelectedItem;

                int z = bakery_service.GetAvailableSandwiches().Length;

                bakery_service.AddSandwich(this.tbxName.Text, _bread, double.Parse(this.textBox1.Text));

                foreach (int o in listBox1.SelectedIndices)
                {
                    bakery_service.GetAvailableSandwiches()[z].AddIngredient(i[o]);
                }

            }
            this.Close();
        }
    }
}
