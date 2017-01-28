using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
