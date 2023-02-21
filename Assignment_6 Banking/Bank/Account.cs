using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3)	Write a console Application for banking domain, having Account class with data members as account number, customer name, balance . 
 * It should have Withdraw and Deposit methods for performing banking transaction. It should also define UnderBalance, BalanceZero events. 
 * These events would be raised when balance of account is less than certain amount and equal to zero respectively.
*/
namespace Assignment_Banking
{
    class Account
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                functions k = new functions();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k.Deposit();
                        break;
                    case 2:
                        k.Withdraw();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this Transaction? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            // Console.ReadKey();
        }
    }
}


