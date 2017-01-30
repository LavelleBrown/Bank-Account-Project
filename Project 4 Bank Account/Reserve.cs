using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4_Bank_Account
{
    class Reserve: Account
    {
        //Fields
        private double reserveBal;
        private double reserveAcct;

        //Constructors
        public Reserve()
        {

        }
        public Reserve(double reserveBal, double reserveAcct)
        {

        }

        //Properties
        public double ReserveBalance
        {
            get { return this.reserveBal; }
            set { this.reserveBal = value; }
        }
        public double ReserveAccount
        {
            get { return this.reserveAcct; }
            set { this.reserveAcct = value; }
        }
        //Methods
        public override void DisplayBalance()
        {
            Console.WriteLine();
            Console.WriteLine(reserveAcct);
            Console.WriteLine("Your Account Balance is $" + reserveBal);
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
            StreamWriter writer = new StreamWriter(@"BankStatement");

            using (writer)
            {
                writer.WriteLine("Account Name: Lavelle Brown");
                writer.WriteLine("Account Balance: $" + AccountBal);
                writer.WriteLine("Transaction Date: " + DateTime.Now);

            }


        }

    }

}
