using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the total no of employee");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = new int[n];
            string[] w = new string[n];
            double[] f = new double[n];
            for (int d = 0; d < n; d++)
            {
                Console.WriteLine("enter the " + (d + 1) + "st Employee  Number");
                q[d] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the " + (d + 1) + "st Employee Name");
                w[d] = Console.ReadLine();
                Console.WriteLine("enter the " + (d + 1) + "st Employee Salary");
                f[d] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int x = 0; x < n; x++)
            {
                Employee e = new Employee(q[x], w[x], f[x]);
                e.set(f[x]);
                e.get();
            }
        }
    }
}
