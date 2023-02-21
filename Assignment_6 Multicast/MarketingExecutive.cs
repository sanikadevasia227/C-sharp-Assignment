using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Multicast
{
    class MarketingExecutive : Employees
    {
        double PF, TDS, NetSalary = 0;
        private double GrossSalary1 = 0.0;
        private double KilometersTravelled;
        private double tourallow;
        private double telephoneallow;
        private double Salary;
        private double TotalSalary;
        public MarketingExecutive(int id, String name, Date JoiningDt, Department department, double salary, int kilo, double sal) : base(id, name, salary, JoiningDt, department)
        {
            Salary = sal;
            KilometersTravelled1 = kilo;
            Tourallow = 5 * KilometersTravelled1;
            telephoneallow = 1000;
        }

        public double KilometersTravelled1 { get => KilometersTravelled; set => KilometersTravelled = value; }
        public double Tourallow { get => tourallow; set => tourallow = value; }

        public override double CalculateSalary()
        {
            TotalSalary = Salary + Tourallow + telephoneallow;
            return TotalSalary;
        }

        //Overriding ToString Method for string representation of an object
        public override string ToString()
        {
            return ToString() + "\nKilometers Travelled = " + KilometersTravelled1 + "\nTour Allowance = " + Tourallow + "\nTelephone Allowances =" + telephoneallow + "\nTotal Salary = " + CalculateSalary();
        }
        public double CalculateNetSalary(double Salary)
        {
            if (Salary < 5000)
            {
                GrossSalary1 = Salary + (Salary * .10) + (Salary * .05) + (Salary * .15);

            }
            else if (Salary < 10000)
            {
                GrossSalary1 = Salary + (Salary * .15) + (Salary * .10) + (Salary * .20);
            }
            else if (Salary < 15000)
            {
                GrossSalary1 = Salary + (Salary * .20) + (Salary * .15) + (Salary * .25);
            }
            else if (Salary < 20000)
            {
                GrossSalary1 = Salary + (Salary * .25) + (Salary * .20) + (Salary * .30);
            }
            else if (Salary >= 20000)
            {
                GrossSalary1 = Salary + (Salary * .30) + (Salary * .25) + (Salary * .35);
            }

            PF = GrossSalary1 * .10;
            TDS = GrossSalary1 * .18;
            NetSalary = GrossSalary1 - (PF + TDS);
            return NetSalary;
            Console.WriteLine("NetSalary is :" + NetSalary);
        }
        public double print(double NetSal)
        {
            PF = GrossSalary1 * .10;
            TDS = GrossSalary1 * .18;
            NetSalary = GrossSalary1 - (PF + TDS);
            return NetSalary;
            Console.WriteLine("NetSalary is :" + NetSalary);
        }
    }
}
