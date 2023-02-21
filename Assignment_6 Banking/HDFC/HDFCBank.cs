using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HDFC_Event_handling
{
    public delegate void TransactionHandler(object sender, TransactionEventArgs e); // Delegate Definition

    public class TransactionEventArgs
    {
        public double TranactionAmount { get; set; }
        public string TranactionType { get; set; }

        public TransactionEventArgs(double amt, string type)
        {
            TranactionAmount = amt;
            TranactionType = type;
        }
    }

    class HDFCBank
    {
        string name;
        int account;
        public event TransactionHandler TransactionMade; // Event Definition
        public double BalanceAmount, debitAmount, creditAmount;

        public HDFCBank(double amount)
        {
            this.BalanceAmount = amount;

        }


        public void Debit()
        {

            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            debitAmount = Convert.ToDouble(Console.ReadLine());

            if (debitAmount <= BalanceAmount + 1000)
            {


                BalanceAmount = BalanceAmount - debitAmount;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Debited!");
                OnTransactionMade(e); // Debit transaction made

                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);

                /*  {
                      Console.WriteLine(e.TranactionType + "Transaction cannot be continued below specified limit of	Rs.-1000");
                  }*/

                Console.WriteLine(e.TranactionType + "After Withdraw Amount Balance is : " + BalanceAmount);

            }
            /*    else if(debitAmount>=(BalanceAmount1000))
            {
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Zero Balance!");
                Console.WriteLine(e.TranactionType + "Transaction cannot be continued below specified limit of	Rs.-1000");
            }*/
            else if (debitAmount >= BalanceAmount + 1000 || BalanceAmount == 0)
            {
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "Zero Balance!");
                Console.WriteLine(e.TranactionType + "Transaction cannot be continued below specified limit of	Rs.-1000");
                // Console.WriteLine(e.TranactionType + "Balance Amount is:" + BalanceAmount);
            }
            else
            {
                TransactionEventArgs e = new TransactionEventArgs(debitAmount, "\n\nWithdraw Ammount does not Exist your Account(UnderBanlance). ");
                Console.WriteLine(e.TranactionType + "Balance Amount is:" + BalanceAmount);
            }

        }
        public void Credit()
        {

            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            creditAmount = Convert.ToDouble(Console.ReadLine());
            BalanceAmount = BalanceAmount + creditAmount;
            TransactionEventArgs e = new TransactionEventArgs(creditAmount, "Credited!");
            OnTransactionMade(e); // Credit transaction made
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine(e.TranactionType + "Total Balance amount in the account  : " + BalanceAmount);

        }
        protected virtual void OnTransactionMade(TransactionEventArgs e)
        {
            if (TransactionMade != null)
            {
                TransactionMade(this, e); // Raise the event 
            }
        }
    }
}
