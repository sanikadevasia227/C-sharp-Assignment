using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public void set(double Sal)
        {
            if (Sal < 5000)
            {
                HRA = (Sal * 0.1);
                TA = (Sal * 0.05);
                DA = (Sal * 0.15);
                GrossSalary = Sal + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
            else if (Sal >= 5000 && Sal < 10000)
            {
                HRA = (Sal * 0.15);
                TA = (Sal * 0.1);
                DA = (Sal * 0.2);
                GrossSalary = Sal + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
            else if (Sal >= 10000 && Sal < 15000)
            {
                HRA = (0.2 * Sal);
                TA = (Sal * 0.15);
                DA = (Sal * 0.25);
                GrossSalary = Sal + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
            else if (Sal >= 15000 && Sal < 20000)
            {
                HRA = (Sal * 0.25);
                TA = (Sal * 0.2);
                DA = (Sal * 0.3);
                GrossSalary = Sal + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
            else
            {
                HRA = (Sal * 0.3);
                TA = (Sal * 0.25);
                DA = (Sal * 0.35);
                GrossSalary = Sal + HRA + TA + DA;
                PF = 0.1 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
        }

        public void get()
        {
            Console.WriteLine("Empyoee No :" + EmpNo);
            Console.WriteLine("Empyoee Name : " + EmpName);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("HRA : " + HRA);
            Console.WriteLine("TA : " + TA);
            Console.WriteLine("DA : " + DA);
            Console.WriteLine("GrossSalary : " + GrossSalary);
            Console.WriteLine("PF : " + PF);
            Console.WriteLine("TDS : " + TDS);
            Console.WriteLine("NetSalary : " + NetSalary);
            Console.WriteLine("--------------------------------------------------");
        }
        public Employee(int a, string b, double c)
        {
            EmpNo = a;
            EmpName = b;
            Salary = c;
        }

    }
}

