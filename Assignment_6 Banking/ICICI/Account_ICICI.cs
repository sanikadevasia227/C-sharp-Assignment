using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_ICICI
{
    class Account_ICICI
    {
        private static void SendNotification(object sender, TransactionEventArgs e)
        {
            Console.WriteLine("Your Account is {0} for Rs.{1} ", e.TranactionType, e.TranactionAmount);

        }
        static void main()
        {

            char agn;
            do
            {
                ICICIBank k = new ICICIBank(000);

                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k.Credit();
                        k.TransactionMade += new TransactionHandler(SendNotification);
                        break;
                    case 2:
                        k.Debit();
                        k.TransactionMade += new TransactionHandler(SendNotification);
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this Transaction? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            //Console.ReadKey();
        }
    }
}
