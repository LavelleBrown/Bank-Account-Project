using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4_Bank_Account
{
    class Savings: Account
    {
        //Fields
        private double savingsBal;
        private double savingsAcct;

        //Constructors
        public Savings():base("Lavelle Brown", "Savings", accountBal)
        {

        }
        public Savings(double savingsBal, double savingsAcct)
        {

        }

        //Properties
        public double SavingsBalance
        {
            get { return this.savingsBal; }
            set { this.savingsBal = value; }
        }
        public double SavingsAccount
        {
            get { return this.savingsAcct; }
            set { this.savingsAcct = value; }
        }
        public static double accountBal { get; set; }

        //Methods
        public override void DisplayBalance()
        {
            Console.WriteLine();
            Console.WriteLine(savingsAcct);
            Console.WriteLine("Your Account Balance is $" + savingsBal);
            Console.WriteLine("Transaction Date: " + DateTime.Now);
        }
        public override void DisplayAcctInfo()
        {
            Console.WriteLine("Account Name: Lavelle Brown");
            Console.WriteLine("Transaction Date: " + DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("What transaction would you like to make?");
        }
        public virtual void WriteToFile(string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);

            using (writer)
            {
                writer.WriteLine("Account Name: Lavelle Brown");
                writer.WriteLine("Account Balance: $" + accountBal);
                writer.WriteLine("Transaction Date: " + DateTime.Now);

            }


        }


    }
}
