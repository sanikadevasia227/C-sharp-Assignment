using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_5
{
    class Assignment1Circle
    {
        public double circumference1(double r)
        {
            double a1 = 2 * 3.142 * r;
            return a1;
        }
        public double area1(double r)
        {
            double a2 = 3.142 * r * r;
            return a2;
        }
        public static void Main()
        {
            Assignment1Circle c = new Assignment1Circle();
            double rad, ar, cir;
            Console.WriteLine("Enter the radius : ");
            rad = Convert.ToDouble(Console.ReadLine());
            ar = c.area1(rad);
            cir = c.circumference1(rad);
            Console.WriteLine("area of circle is{0}", ar);
            Console.WriteLine("Circumference of circle is {0}", cir);
            Console.ReadLine();
        }
    }
}

