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
    public partial class CreditAccountForm : AbstractBalanceCreditDebit
    {
        public CreditAccountForm()
        {
            InitializeComponent();
            idtype = IDType.Account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccountIDExists(textBox1.Text))
            {
                CreditAccount(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Account ID entered is not recognised", "ID not recognised", 0, MessageBoxIcon.Exclamation);
            }
        }

        private void CreditAccount(string accountID)
        {


        }
    }
}
