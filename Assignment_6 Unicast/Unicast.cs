using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Unicast
{
    public delegate void EmployeeDelegate();
    class Unicast
    {
        static void Main(string[] args)
        {

            EmployeeDelegate employeeDelegate = new EmployeeDelegate(unidel.Unidel);
            employeeDelegate();
            Console.ReadKey();

            //  Console.WriteLine(manager);
        }
        class unidel
        {
            public static void Unidel()
            {
                Console.WriteLine("Enter Number of Employee:");
                int ne = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ne; i++)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Enter Employee ID:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("HR=1, ACCOUNTS=2, PRODUCTION=3, PACKING=4, DISPATCH=5, SALES=6");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Enter Employee Dept:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Department dept = (Department)n;
                    Console.WriteLine("Enter Employee Salary:");
                    double sal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter a year: ");
                    int Year = int.Parse(Console.ReadLine());
                    if (Year >= 1 && Year <= 9999) //year validation
                    {
                        Console.WriteLine("Year valid");
                    }
                    else
                    {
                        Console.WriteLine("Entered YEAR OUT OF RANGE");
                    }
                    Console.Write("Enter a month: ");
                    int Month = Convert.ToInt32(Console.ReadLine());
                    if (Month >= 1 && Month <= 12)
                    { //Month validation
                        Console.WriteLine("Month valid");
                    }
                    else
                    {
                        Console.WriteLine("Entered month NOT VALID");
                    }
                    Console.Write("Enter a day: ");
                    int Day = Convert.ToInt32(Console.ReadLine());
                    if (Day >= 1 && Day <= DateTime.DaysInMonth(Year, Month))//day validation
                    {
                        Console.WriteLine("DAY valid");
                    }
                    else
                    {
                        Console.WriteLine("Entered DAY NOT VALID");
                    }
                    Manager manager = new Manager(id, name, new Date(Month, Day, Year), dept, sal);
                    Console.WriteLine(manager);
                    Manager1 manager1 = new Manager1(id, name, new Date(Month, Day, Year), dept, sal);
                    Console.WriteLine(manager1);
                }
            }
        }
    }
}
