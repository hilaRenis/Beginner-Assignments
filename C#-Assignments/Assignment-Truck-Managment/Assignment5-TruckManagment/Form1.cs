using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_TruckManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (rbt_TypeA.Checked)
            {
                lbl_Result.Text = " ";
                TypeA();
            }
            else if (rbt_TypeB.Checked)
            {
                lbl_Result.Text = " ";
                TypeB();
            }
            else if (rbt_TypeC.Checked)
            {
                lbl_Result.Text = " ";
                TypeC();
            }
            else
            {
                MessageBox.Show("Please check one of the truck types!");
            }
        }

        private int convertNumberOfOrder()
        {
            return Convert.ToInt32(tb_boxToShip.Text);
        } 

        private string TypeA()
        {
            int numberPallet = 20;
            int numberBox = 30;

            return lbl_Result.Text = (convertNumberOfOrder() / (numberPallet * numberBox)).ToString();

            
        }

        private string TypeB()
        {
            int numberPallet = 24;
            int numberBox = 30;

            return lbl_Result.Text = (convertNumberOfOrder() / (numberPallet * numberBox)).ToString();
        }

        private string TypeC()
        {
            int numberPallet = 28;
            int numberBox = 35;

            return lbl_Result.Text = (convertNumberOfOrder() / (numberPallet * numberBox)).ToString();
        }
    }
}
