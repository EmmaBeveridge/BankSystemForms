using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Account
    {
        private string Holder;
        private string AccountID;
        private DateTime TimeCreated;
        private static HashSet<string> AccountIDs = new HashSet<string>();
        private decimal decBalance;
        private static List<Account> AllAccounts = new List<Account>();

        public Account(string CustomerID, DateTime argTimeCreated)
        {
            Holder = CustomerID;
            TimeCreated = argTimeCreated;
            AccountID = GenerateUniqueID();



        }

        public DateTime getTimeCreated
        {
            get
            {
                return TimeCreated;
            }
        }

        public static List<Account> getAllAccounts
        {
            get
            {
                return AllAccounts;
            }
        }

        public static void AddAccount(Account accountToAdd )
        {
            AllAccounts.Add(accountToAdd);
        }


        public static HashSet<string> getAllAccountIDs
        {
            get
            {
                return AccountIDs;
            }

        }


        public string getAccountHolderID
        {
            get
            {
                return Holder;
            }
        }

        public string getAccountID
        {
            get
            {
                return AccountID;
            }
        }


        public decimal getsetBalance
        {
            get
            {
                return decBalance;
            }
            set
            {
                decBalance = value;
            }
        }




        private string GenerateUniqueID()
        {
            Random rand = new Random();
            bool containsID = true;
            int intNewID = 0;
            string strNewID = "";
            while (containsID)
            {
                intNewID = rand.Next(0, 99999999);
                strNewID = intNewID.ToString().PadLeft(8, '0');
                if (!AccountIDs.Contains(strNewID))
                {
                    containsID = false;
                    AccountIDs.Add(strNewID);
                    break;
                }
            }

            return (strNewID);

        }

    }
}
