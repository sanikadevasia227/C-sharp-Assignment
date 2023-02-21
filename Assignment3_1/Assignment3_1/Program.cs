using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    interface IPrintable
    {
        string details();
    }
    class Employees : IPrintable
    {
        private int id;
        private String name;
        private double salary; 
        public Employees(int id, String name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public virtual double CalculateSalary()
        {
            return salary;
        }

        public string details()
        {
            return "\nEmployee Id = " + id + "\nEmployee Name = " + name + "\nBasic Salary = " + salary;
        }
    }
    class Manager : Employees, IPrintable
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double TotalSalary = 0.0;
        public Manager(int id, String name, double salary) : base(id, name, salary)
        {
            PetrolAllowance = salary * 0.08;
            FoodAllowance = salary * 0.13;
            OtherAllowance = salary * 0.03;
        }
        public override double CalculateSalary()
        {
            TotalSalary = base.CalculateSalary() + FoodAllowance + OtherAllowance + PetrolAllowance;
            return TotalSalary;
        }
        public string details()
        {
            return base.details() + "\nPetrol Allowance = " + PetrolAllowance + "\nFood Allowance = " + FoodAllowance + "\nOther Allowance = " + OtherAllowance + "\nTotal Salary = " + CalculateSalary();
        }
    }
    class MarketExecutive : Manager, IPrintable
    {
        private double KilometerTravel;
        private double TourAllowance;
        private double TelephoneAllowance;
        private double TotalSalary;
        public MarketExecutive(int id, string name, double salary, double kilo) : base(id, name, salary)
        {
            KilometerTravel = kilo;
            TourAllowance = 5 * kilo;
            TelephoneAllowance = 1000;
        }
        public override double CalculateSalary()
        {
            TotalSalary = KilometerTravel + TourAllowance + TelephoneAllowance;
            return TotalSalary;
        }

        public string details()
        {
            return base.details() + "\n Kilometer Travel = " + KilometerTravel + "\n Tour Allowance = " + TourAllowance + "\n Telephone Allowance = " + TelephoneAllowance + "\n Total Manager Executive Expenses = " + CalculateSalary() + "\ntotal net salary = " + (CalculateSalary() + base.CalculateSalary());
        }
    }
    class MainProgramofEmpManagerDemo
    {
        static void Main()
        {
            MarketExecutive m = new MarketExecutive(101, "balu", 20000, 1000);
            Console.WriteLine(m.details());
            Console.WriteLine("----------------------------------------------------");
            MarketExecutive m1 = new MarketExecutive(102, "raju", 30000, 3000);
            Console.WriteLine(m1.details());
            Console.ReadKey();

        }
    }
}

