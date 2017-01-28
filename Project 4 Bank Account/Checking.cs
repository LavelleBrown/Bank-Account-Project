using Project_4_Bank_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Bank_Account
{
    class Checking: Account
    {
        //Fields
        private double checkingAcct;

        //Constructors
        public Checking(double accountBal):base("Lavelle Brown", "Checking", accountBal )
        {

        }

        //Properties
       
        public double CheckingAccount
        {
            get { return this.checkingAcct; }
            set { this.checkingAcct = value; }
        }
        public void CheckDeposit()
        {
            Console.WriteLine("Enter amount you would like to deposit.");
            double amount = int.Parse(Console.ReadLine());
            AccountBal = AccountBal + amount;
            Console.WriteLine("Transaction complete. Here is your new balance.");
        }

        
    }
}
