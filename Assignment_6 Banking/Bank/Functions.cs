using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Banking
{
    class functions
    {
        bankbalance i = new bankbalance();
        string name;
        int account;
        double withdraw, dep, tobal;

        public void Deposit()
        {

            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            tobal = i.bal + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + tobal);


        }
        public void Withdraw()
        {
            try
            {
                Console.WriteLine("Enter Account Name :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number  :");
                account = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount :");
                withdraw = Convert.ToDouble(Console.ReadLine());
                if (withdraw <= i.bal)
                {
                    tobal = i.bal - withdraw;
                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("Account Name : " + name);
                    Console.WriteLine("Account Number: " + account);
                    Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
                }
                else if (i.bal == 0)
                {
                    throw new BankExeception("Balance Is Zero!");
                }
                else
                    throw new BankExeception("\n\nWithdraw Ammount does not Exist your Account(UnderBanlance). ");
            }
            catch (BankExeception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
