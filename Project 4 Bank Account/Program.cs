using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_4_Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Reserve reserve = new Reserve();
            Checking checking = new Checking();
            Savings savings = new Savings();
            Console.WriteLine("Welcome to Your Money is Our Money Savings and Loans");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("MENU____________________________________");
                Console.WriteLine("Which account would you like to access?");
                Console.WriteLine("Enter 1 for Checking.");
                Console.WriteLine("Enter 2 for Savings.");
                Console.WriteLine("Enter 3 for Reserve.");
                Console.WriteLine("Enter 4 to log out.");

                int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    
                    Console.WriteLine("Checking Account");
                    checking.DisplayAcctInfo();
                   
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("Savings Account");
                    savings.DisplayAcctInfo();
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("Reserve Account");
                    reserve.DisplayAcctInfo();   
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("Thank you. Log out successful");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }



                Console.WriteLine("Enter 1 to check balance.");
                Console.WriteLine("Enter 2 to make a deposit.");
                Console.WriteLine("Enter 3 to make a withdrawl.");
                Console.WriteLine("Enter 4 to log out.");

                
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    checking.DisplayBalance();
                    Console.WriteLine();
                    checking.WriteToFile();
                }
                else if (choice == 2)
                {
                    savings.MakeDeposit();
                    savings.DisplayAcctInfo();
                    savings.WriteToFile();
                }
                else if (choice == 3)
                {
                    reserve.MakeWithdrawl();
                    reserve.DisplayAcctInfo();
                    reserve.WriteToFile();
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
