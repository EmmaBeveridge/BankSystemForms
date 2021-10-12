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
    public partial class CreateNewCustomerForm : Form
    {
        
        
        public CreateNewCustomerForm()
        {
            InitializeComponent();
            
        }
        
        
        private void CreateNewCustomerForm_Load(object sender, EventArgs e)
        {
            
        }

         

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string InputEmail = textBoxEmail.Text;
            if (!Customer.CheckEmail(InputEmail))
            {
                labelEmailValid.ForeColor = System.Drawing.Color.Red;
                labelEmailValid.Text = "Email Invalid";
            }
            else
            {
                labelEmailValid.ForeColor = System.Drawing.Color.LimeGreen;
                labelEmailValid.Text = "Email Valid";
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string argForename = textBoxForename.Text;
            string argSurname = textBoxSurname.Text;
            string argEmail = textBoxEmail.Text;
            DateTime argDOB = dateTimePickerDOB.Value;
            Customer customerTemp = new Customer(argForename, argSurname, argEmail, argDOB);
            if (customerTemp.getsetForename=="invalid")
            {
                labelForenameInvalid.Text = "Please enter a forename before submitting";
            }
            if (customerTemp.getsetSurname=="invalid")
            {
                labelSurnameInvalid.Text = "Please enter a surname before submitting";
            }
            if (customerTemp.getsetEmail=="invalid")
            {
                labelEmailValid.Text = "Please enter a valid email before submitting";
            }
            if(!(customerTemp.getsetForename=="invalid")&&!(customerTemp.getsetSurname=="invalid")&&!(customerTemp.getsetEmail=="invalid"))
            {
                MessageBox.Show($"New customer created with ID: {customerTemp.getCustomerID}", "New customer created");
                Customer.AddCustomer(customerTemp);
                this.Owner.Show();
                this.Close();
                

            }
        }

        private void CreateNewCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void textBoxForename_TextChanged(object sender, EventArgs e)
        {
            string forenamenowhitespace = Regex.Replace(textBoxForename.Text, @"\s+" , "");
            if (!(forenamenowhitespace==""))
            {
                labelForenameInvalid.ForeColor = System.Drawing.Color.LimeGreen;
                labelForenameInvalid.Text = "Forename valid";
            }
            else
            {
                labelForenameInvalid.ForeColor = System.Drawing.Color.Red;
                labelForenameInvalid.Text = "Forename invalid";
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            string surnamenowhitespace = Regex.Replace(textBoxSurname.Text, @"\s+", "");
            if (!(surnamenowhitespace == ""))
            {
                labelSurnameInvalid.ForeColor = System.Drawing.Color.LimeGreen;
                labelSurnameInvalid.Text = "Surname valid";
            }
            else
            {
                labelSurnameInvalid.ForeColor = System.Drawing.Color.Red;
                labelSurnameInvalid.Text = "Surname invalid";
            }

        }

        private void CreateNewCustomerForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
