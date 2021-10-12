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

namespace BankSystemForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateCustomer_Click(object sender, EventArgs e)
        {
            
            CreateNewCustomerForm createnewcustomerform = new CreateNewCustomerForm();
            createnewcustomerform.Owner = this;
            createnewcustomerform.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccount createnewaccountform = new CreateNewAccount();
            createnewaccountform.Owner = this;
            createnewaccountform.Show();
            this.Hide();
        }

        
        

        private void buttonViewBalance_Click_1(object sender, EventArgs e)
        {
            ViewBalanceForm viewBalanceForm = new ViewBalanceForm();
            viewBalanceForm.Owner = this;
            this.Hide();
            viewBalanceForm.Show();


        }
    }
}
