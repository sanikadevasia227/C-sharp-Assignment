using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5)	Write separate HDFCBank class with EventHandlers for UnderBalance and
BalanceZero Events.
a)  EventHandler should allow account holder to withdraw money till balance goes to Rs - 1000; below this show message "Transaction cannot be continued below specified limit of	Rs.-1000".

*/
namespace HDFC_Event_handling
{
    class Account_HDFC
    {
        private static void SendNotification(object sender, TransactionEventArgs e)
        {
            Console.WriteLine("Your Account is {0} for Rs.{1} ", e.TranactionType, e.TranactionAmount);

        }
        static void Main(string[] args)
        {

            char agn;
            do
            {
                HDFCBank k = new HDFCBank(000);

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
