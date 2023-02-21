using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Unicast
{
    class Manager1 : Employees
    {
        double PF, TDS, NetSalary = 0;
        private double GrossSalary1 = 0.0;
        public Manager1(int id, String name, Date JoiningDt, Department department, double salary)
            : base(id, name, salary, JoiningDt, department)
        {

        }
        public double GrossSalary11 { get => GrossSalary1; set => GrossSalary1 = value; }



        public override double CalculateSalary()
        {
            if (base.Salary < 5000)
            {
                GrossSalary1 = base.Salary + (base.Salary * .10) + (base.Salary * .05) + (base.Salary * .15);

            }
            else if (base.Salary < 10000)
            {
                GrossSalary1 = base.Salary + (base.Salary * .15) + (base.Salary * .10) + (base.Salary * .20);
            }
            else if (base.Salary < 15000)
            {
                GrossSalary1 = base.Salary + (base.Salary * .20) + (base.Salary * .15) + (base.Salary * .25);
            }
            else if (base.Salary < 20000)
            {
                GrossSalary1 = base.Salary + (base.Salary * .25) + (base.Salary * .20) + (base.Salary * .30);
            }
            else if (base.Salary >= 20000)
            {
                GrossSalary1 = base.Salary + (base.Salary * .30) + (base.Salary * .25) + (base.Salary * .35);
            }



            PF = GrossSalary1 * .10;
            TDS = GrossSalary1 * .18;
            NetSalary = GrossSalary1 - (PF + TDS);
            return NetSalary;
        }

        public override string ToString()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("NetSalary without Allowance:");
            return base.ToString() + "\nNet Salary = " + CalculateSalary();
        }
    }
}