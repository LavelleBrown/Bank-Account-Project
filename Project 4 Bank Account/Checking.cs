using Project_4_Bank_Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4_Bank_Account
{
    class Checking: Account
    {
        //Fields
        private double checkingAcct;
        

        //Constructors
        public Checking()
        {

        }
        public Checking(double accountBal):base("Lavelle Brown", "Checking", accountBal )
        {

        }

        //Properties
       
        public double CheckingAccount
        {
            get { return this.AccountBal; }
            set { this.checkingAcct = value; }
        }
     

        //Methods
        public void CheckDeposit()
        {
            Console.WriteLine("Enter amount you would like to deposit.");
            double amount = int.Parse(Console.ReadLine());
            AccountBal = AccountBal + amount;
            Console.WriteLine("Transaction complete. Here is your new balance.");
        }
        public override void DisplayBalance()
        {
            Console.WriteLine();
            Console.WriteLine(checkingAcct);
            Console.WriteLine("Your Account Balance is $" + AccountBal);
            Console.WriteLine("Transaction Date: " + DateTime.Now);
        }
        public override void DisplayAcctInfo()
        {
            Console.WriteLine("Account Name: Lavelle Brown");
            Console.WriteLine("Transaction Date: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("What transaction would you like to make?");
        }
        public override void WriteToFile()
        {
            StreamWriter writer = new StreamWriter(@"BankStatement.txt");

            using (writer)
            {
                writer.WriteLine("Account Name: Lavelle Brown");
                writer.WriteLine("Account Balance: $" + AccountBal);
                writer.WriteLine("Transaction Date: " + DateTime.Now);

            }


        }



    }
}
