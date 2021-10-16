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
    public partial class CreateNewAccount : AbstractBalanceCreditDebit
    {
        
        public CreateNewAccount()
        {
            
            InitializeComponent();

            idtype = IDType.Customer;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (CustomerIDExists(textBox1.Text))
            {
                string customerIDnowhitespace = Regex.Replace(textBox1.Text, @"\s+", "");
                List<Customer> AllCustomers = Customer.getAllCustomers;
                Customer AccountHolder = AllCustomers.Find(customer => customer.getCustomerID == customerIDnowhitespace);
                string AccountID = AccountHolder.AddAccountForCustomer(customerIDnowhitespace, DateTime.Now);
                MessageBox.Show($"New account created with ID : {AccountID}", "New Account Created");
                               
            }
            else
            {
                MessageBox.Show("Customer ID entered is not recognised", "Invalid ID Entered", 0, MessageBoxIcon.Exclamation);
            }
        }
    }
}
