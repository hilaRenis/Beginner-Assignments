using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_week11
{
    public class BankAccount
    {
        private string client;
        private int accountNo;
        private double balance;

        public void InitializeBankAccount(string newClient, int newAccountNo)
        {
            newClient = client;
            newAccountNo = accountNo;
            balance = 0;
        }

        public void DepositMoney(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            return;
        }

        public bool WithdrawMoney(double amount)
        {
            if (balance >= amount && amount > 0)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public string SeeTheBalance()
        {
            return balance + " €";
        }

        public string GetInfo()
        {
            return "Client: " + client + "with account number: ( " + accountNo + " )";
        }

        public int AccountNo()
        {
            return accountNo;
        }

        public string ClientName()
        {
            return client;
        }
    }
}
