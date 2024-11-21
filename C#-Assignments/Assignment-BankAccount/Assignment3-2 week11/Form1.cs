using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_2_week11
{
    public partial class Form1 : Form
    {
        private BankAccount chekingAccount = new BankAccount();
        private BankAccount savinAccount = new BankAccount();

        public Form1()
        {
            InitializeComponent();
            chekingAccount.InitializeBankAccount("Renis",1234);
            accNo_lbl.Text = chekingAccount.AccountNo().ToString();
            clientName_lbl.Text = chekingAccount.ClientName();

            savinAccount.InitializeBankAccount("Renis", 1234);
            accNo_lbl.Text = savinAccount.AccountNo().ToString();
            clientName_lbl.Text = savinAccount.ClientName();
        }

        private void deposit_btn_Click(object sender, EventArgs e)
        {
            if (chekingAcc_rb.Checked)
            {
                chekingAccount.DepositMoney(Convert.ToDouble(amount_tb.Text));
                chekingAcc_lbl.Text = chekingAccount.SeeTheBalance();
            }
            else if (savingAcc_rb.Checked)
            {
                savinAccount.DepositMoney(Convert.ToDouble(amount_tb.Text));
                savingAcc_lbl.Text = savinAccount.SeeTheBalance();
            }
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            if (chekingAcc_rb.Checked)
            {
                chekingAccount.WithdrawMoney(Convert.ToDouble(amount_tb.Text));
                chekingAcc_lbl.Text = chekingAccount.SeeTheBalance();
            }
            else if (savingAcc_rb.Checked)
            {
                savinAccount.WithdrawMoney(Convert.ToDouble(amount_tb.Text));
                savingAcc_lbl.Text = savinAccount.SeeTheBalance();
            }
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            if (chekingAcc_rb.Checked)
            {
                MessageBox.Show(chekingAccount.GetInfo());
            }
            else if (savingAcc_rb.Checked)
            {
                MessageBox.Show(savinAccount.GetInfo());
            }
        }
    }
}
