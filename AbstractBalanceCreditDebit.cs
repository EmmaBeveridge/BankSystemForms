using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BankingSystem;


namespace BankSystemForms
{
    public partial class AbstractBalanceCreditDebit : Form
    {
        public AbstractBalanceCreditDebit()
        {
            InitializeComponent();
        }

        protected void textBox1_TextChanged(object sender, EventArgs e)
        {
            string accountIDnowhitespace = Regex.Replace(textBox1.Text, @"\s+", "");
            if (accountIDnowhitespace.Length < 8)
            {
                labelError.Text = "ID entered is too short";
                
                if (!int.TryParse(accountIDnowhitespace, out _))
                {
                    labelError.Text += "\nand can only contain digits";
                }
                
                
            }
            else if (accountIDnowhitespace.Length > 8)
            {
                labelError.Text = "ID entered is too long";
                if (!int.TryParse(accountIDnowhitespace, out _))
                {
                    labelError.Text += "\nand can only contain digits";
                }
            }
 
            else if (!int.TryParse(accountIDnowhitespace, out _))
            {
                labelError.Text = "ID must only contain digits";

            }

            else
            {
                labelError.Text = "";
            }
        }

        protected bool AccountIDExists(string accountID)
        {
            string accountIDnowhitespace = Regex.Replace(accountID, @"\s+", "");
            HashSet<string> allAccountIDs = Account.getAllAccountIDs;
            if (allAccountIDs.Contains(accountIDnowhitespace))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void AbstractBalanceCreditDebit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void AbstractBalanceCreditDebit_Load(object sender, EventArgs e)
        {

        }
    }
}
