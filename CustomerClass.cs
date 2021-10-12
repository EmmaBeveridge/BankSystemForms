using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BankingSystem
{
    class Customer
    {
        static int CustomerCount = 0;
        private static HashSet<string> CustomerIDs = new HashSet<string>();
        private string CustomerID;
        private string Forename;
        private string Surname;
        private string Email;
        private DateTime DOB;
        private List<Account> CustomerAccounts = new List<Account>();
        private static List<Customer> AllCustomers = new List<Customer>();
        public Customer(string argForename, string argSurname, string argEmail, DateTime argDOB)
        {
            CustomerCount++;
            CustomerID = GenerateUniqueID();
            getsetForename = argForename;
            getsetSurname = argSurname;
            getsetEmail = argEmail;
            getsetDOB = argDOB;

        }

        public static List<Customer> getAllCustomers
        {
            get
            {
                return AllCustomers;
            }
        }

        public static void AddCustomer (Customer customerToAdd)
        {
            AllCustomers.Add(customerToAdd);
        }



        public DateTime getsetDOB
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        public List<Account> getCustomerAccounts
        {
            get
            {
                return CustomerAccounts;
            }

        }

        public void AddAccount(Account newAccount)
        {
            CustomerAccounts.Add(newAccount);
        }


        public static HashSet<string> getAllCustomerIDs
        {
            get
            {
                return CustomerIDs;
            }

        }

        public string getsetEmail
        {
            get
            {
                return Email;

            }

            set
            {
                bool valid = CheckEmail(value);

                if (valid)
                {
                    Email = value;
                }
                else
                {
                    Email = "invalid";
                }

            }
        }

        public static bool CheckEmail(string strEmail)
        {
            bool AtSignReached = false;
            bool DotReached = false;
            string strEmailname = "";
            string strEmailHost = "";
            string strEmailSuffix = "";


            foreach (var character in strEmail)
            {
                if (character.ToString() == " ")
                {
                    return false;
                }
                else if (character.ToString() == "@")
                {
                    AtSignReached = true;
                    if (strEmailname == "")
                    {

                        return false;
                    }

                }
                if (!AtSignReached)
                {
                    strEmailname += character;
                }

                if (AtSignReached && !DotReached)
                {
                    strEmailHost += character;
                }

                if (character.ToString() == ".")
                {
                    DotReached = true;

                }
                else if (DotReached)
                {
                    strEmailSuffix += character;

                    if (!Char.IsLetter(character))
                    {
                        return false;
                    }
                }
            }


            if (strEmail == "")
            {
                return false;

            }
            else
            {
                if (strEmailHost == "")
                {
                    return false;

                }
                if (!AtSignReached)
                {
                    return false;
                }

                if (!DotReached)
                {
                    return false;

                }

                return true;
            }


        }

        public string getsetForename
        {
            set
            {
                string strForenameNoWhitespace = Regex.Replace(value, @"\s+", "");
                if (!(strForenameNoWhitespace == ""))
                {
                    Forename = value.ToUpper();
                }
                else
                {
                    Forename = "invalid";
                }

            }
            get
            {
                return Forename;
            }
        }

        public string getsetSurname
        {
            set
            {
                string strSurnameNoWhitespace = Regex.Replace(value, @"\s+", "");
                if (!(strSurnameNoWhitespace == ""))
                {
                    Surname = value.ToUpper();
                }
                else
                {
                    Surname = "invalid";
                }


            }
            get
            {
                return Surname;
            }
        }

        public string getCustomerID
        {

            get
            {
                return CustomerID;
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
                if (!CustomerIDs.Contains(strNewID))
                {
                    containsID = false;
                    CustomerIDs.Add(strNewID);
                    break;
                }
            }

            return (strNewID);

        }



    }
}



