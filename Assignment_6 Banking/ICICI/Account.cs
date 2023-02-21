using Assignment_4_IDFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey();
        }
    }
}

namespace Assignment_4_IDFC
{
    public class functions
    {
        internal void Deposit()
        {
            throw new NotImplementedException();
        }

        internal void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}