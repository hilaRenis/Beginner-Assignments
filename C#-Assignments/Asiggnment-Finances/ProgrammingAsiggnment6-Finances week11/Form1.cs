using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAsiggnment6_Finances_week11
{
    public partial class Form1 : Form
    {
        List<Expense> expensesLog = new List<Expense>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addExpense_btn_Click(object sender, EventArgs e)
        {
            expensesLog.Add(new Expense(name_tb.Text, Convert.ToDouble(ammount_upDown_tb.Value)));
        }

        private void showExpense_btn_Click(object sender, EventArgs e)
        {
            showAllExpenses_lb.Items.Clear();
            foreach (Expense newExpense in expensesLog)
            {
                showAllExpenses_lb.Items.Add(newExpense.GetInfo());
            }
        }

        private void showExpensesSame_btn_Click(object sender, EventArgs e)
        {
            showAllExpenses_lb.Items.Clear();
            foreach (Expense newExpense in expensesLog)
            {
                if (newExpense.GetAmount() == Convert.ToDouble(ammount_upDown2_tb.Value))
                {
                    showAllExpenses_lb.Items.Add(newExpense.GetInfo());
                }
            }
        }
    }
}
