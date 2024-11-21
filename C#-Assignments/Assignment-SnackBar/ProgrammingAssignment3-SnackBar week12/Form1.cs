using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAssignment3_SnackBar_week12
{
    public partial class Form1 : Form
    {
        public SnackBar ourSnackBar = new SnackBar();

        public Form1()
        {
            InitializeComponent();
        }

        private void processOrder_btn_Click(object sender, EventArgs e)
        {
            ourSnackBar.ProcessOrder(Int32.Parse(tost_tb.Text), Int32.Parse(croissant_tb.Text), Int32.Parse(cheesecake_tb.Text));
            totalRevenue_tb.Text = ourSnackBar.GetRevenue().ToString();

            tost_tb.Text = "0";
            croissant_tb.Text = "0";
            cheesecake_tb.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tost_lbl.Text = ourSnackBar.snack1.GetName();
            croissant_lbl.Text = ourSnackBar.snack2.GetName();
            cheesecake_lbl.Text = ourSnackBar.snack3.GetName();
            totalRevenue_tb.Text = ourSnackBar.GetRevenue().ToString();

            tost_tb.Text = "0";
            croissant_tb.Text = "0";
            cheesecake_tb.Text = "0";
        }
    }
}
