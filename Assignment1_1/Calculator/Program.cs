using System;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operand (/,+,-,*): ");
            string operand = Console.ReadLine(); 
            switch (operand)
            {
                case "+":
                    int result = n1 + n2;
                    Console.WriteLine("Addition: " + result);
                    break;
                case "-":
                    result = n1 - n2;
                    Console.WriteLine("Subtraction: " + result);
                    break;
                case "*":
                    result = n1 * n2;
                    Console.WriteLine("Multiplication: " + result);
                    break;
                case "/":
                    result = n1 / n2;
                    Console.WriteLine("Division: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid operand");
                    break;
            }
            Console.ReadLine();
        }
    }
}
