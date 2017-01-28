using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static double accountBal { get; private set; }
    }
}
