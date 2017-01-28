using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Bank_Account
{
    class Account
    {
        //Fields

        private string accountName = "Lavelle Brown";
        private string accountType;
        private double accountBal;
      


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

        //Methods
        public void MakeWithdrawl()
        {
            Console.WriteLine("Enter amount you would like to withdraw.");
            double amount = int.Parse(Console.ReadLine());
            accountBal = accountBal - amount;
            Console.WriteLine("Transaction complete. Here is your new balance.");
        }   
        
        public virtual void DisplayAcctInfo()
        {
            Console.WriteLine("Account Name: " + accountName);
            Console.WriteLine();
        }
        public void MakeDeposit()
        {
            Console.WriteLine("Enter amount you would like to deposit.");
            double amount = int.Parse(Console.ReadLine());
            accountBal = accountBal + amount;
            Console.WriteLine("Transaction complete. Here is your new balance.");
        }
     
           

       
    }
    
}
