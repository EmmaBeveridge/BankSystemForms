using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem;
using System.Text.RegularExpressions;

namespace BankSystemForms
{
    public partial class ViewBalanceForm : AbstractBalanceCreditDebit
    {
        public ViewBalanceForm()
        {
            InitializeComponent();
        }

        private void ViewBalanceForm_Load(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountIDExists(textBox1.Text))
            {
                DisplayBalance(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Account ID entered is not recognised", "ID not recognised", 0, MessageBoxIcon.Exclamation);
            }
        }

        private void DisplayBalance(string accountID)
        {
            string accountIDnowhitespace = Regex.Replace(textBox1.Text, @"\s+", "");
            decimal accountBalance = 0m;
            DateTime accountCreated = DateTime.Now;
            string holderID = "";
            string holderName = "";
            string holderEmail = "";
            DateTime holderDOB = DateTime.Now;


            List<Account> AllAccounts = new List<Account>();
            AllAccounts = Account.getAllAccounts;

            List<Customer> AllCustomers = new List<Customer>();
            AllCustomers = Customer.getAllCustomers;

            foreach (Account account in AllAccounts)
            {
                if (account.getAccountID == accountID)
                {
                    accountBalance = account.getsetBalance;
                    accountCreated = account.getTimeCreated;
                    holderID = account.getAccountHolderID;
                }
            }
            foreach (Customer customer in AllCustomers)
            {
                if (holderID == customer.getCustomerID)
                {
                    holderName = customer.getsetForename + " " + customer.getsetSurname;
                    holderEmail = customer.getsetEmail;
                    holderDOB = customer.getsetDOB;
                }

            }

            string Message = $"Customer ID: {holderID}\nCustomer name: {holderName}\nCustomer Email: {holderEmail}\nCustomer DOB: {holderDOB}\nAccount ID:{accountID}\nTime Created: {accountCreated}\nBalance:£{accountBalance}";
            MessageBox.Show(Message, "View Balance");
        }
    }
}
