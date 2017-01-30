using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4_Bank_Account
{
    class Account
    {
        //Fields

        private string accountName = "Lavelle Brown";
        private string accountType;
        private double accountBal;
        protected string filePath = "BankStatement.txt";
    
        //Contructors
        public Account()
        {

        }
        public Account(string accountName)
        {
            this.accountName = accountName;
        }
        public Account(string accountName, string accountType, double accountBal)
        {
            this.accountName = accountName;
            this.accountType = accountType;
            this.accountBal = accountBal;
        }



        //Properties
        public double AccountBal
        {
            get { return this.accountBal; }
            set { accountBal = value; }
        }
        public string ShowType
        {
            get { return this.accountType; }
            set { accountType = value; }
        }
            
    

        //Methods
        public virtual void MakeWithdrawl()
        {
            Console.WriteLine();
            Console.WriteLine("Enter amount you would like to withdraw.");
            double amount = int.Parse(Console.ReadLine());
            accountBal = accountBal - amount;
            Console.WriteLine("Transaction complete. Here is your new balance. $" + accountBal);
        }   
        
        public virtual void DisplayAcctInfo()
        {
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine("Transaction Date: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("What transaction would you like to make?");
        }
        public virtual void MakeDeposit()
        {
            Console.WriteLine();
            Console.WriteLine("Enter amount you would like to deposit.");
            double amount = int.Parse(Console.ReadLine());
            accountBal = accountBal + amount;
            Console.WriteLine("Transaction complete. Here is your new balance: $" + accountBal);
        }
        public virtual void DisplayBalance()
        {
            Console.WriteLine();
            Console.WriteLine(accountType);
            Console.WriteLine("Your Account Balance is $" + accountBal);
            Console.WriteLine("Transaction Date: " + DateTime.Now);
        }
       
        public virtual void WriteToFile()
        {
            StreamWriter writer = new StreamWriter(@"BankStatement.txt");
            
            using (writer)
            {
                writer.WriteLine("Account Name: Lavelle Brown");
                writer.WriteLine("Account Balance: $" + accountBal);
                writer.WriteLine("Transaction Date: " + DateTime.Now);

            }


        }
      

    }
    
}
