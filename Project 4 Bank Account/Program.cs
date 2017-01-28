using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Reserve accountOne = new Reserve();
            Checking account1 = new Checking(100);
            Savings acct1 = new Savings();
            Account acctOne = new Account("Lavelle Brown");
            Console.WriteLine("Welcome to Your Money is Our Money Savings and Loans");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("What transactoion can I help you with?");
                Console.WriteLine();
                Console.WriteLine("Enter 1 to check balance.");
                Console.WriteLine("Enter 2 to make a deposit.");
                Console.WriteLine("Enter 3 to make a withdrawl.");
                Console.WriteLine("Enter 4 to log out.");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    acctOne.DisplayAcctInfo();
                }
                else if (choice == 2)
                {
                    acctOne.MakeDeposit();
                    acctOne.DisplayAcctInfo();
                }
                else if (choice == 3)
                {
                    acctOne.MakeWithdrawl();
                    acctOne.DisplayAcctInfo();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you. Log out successful");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }


                Console.WriteLine("Would you like to make another transaction? Enter 1 for Yes and 2 to log out");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    continue;
                }
                else if (option == 2)
                {
                    Console.WriteLine("Thank you for banking at Your Money is Our Money Savings and Loans");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2.");
                    option = Convert.ToInt32(Console.ReadLine());
                }



            }
        }
    }
}
