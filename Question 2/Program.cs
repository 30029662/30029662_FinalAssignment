using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>Welcome to the Holiday Park's new Payroll System<<<<");
            Console.WriteLine();

            Employee E1 = new Employee();

            //Ask the employee for name, annual gross salary and tax rate
            Console.Write("Please enter your full name: ");
            E1.Name = Console.ReadLine();
            Console.Write("Please enter your annual gross salary: ");
            E1.Gross = double.Parse(Console.ReadLine());
            Console.Write("Please enter your tax rate: ");

            E1.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine("Here is the all information about your payroll");
            Console.WriteLine($"Name: {E1.Name}\nGross salary: ${E1.Gross}\nTax rate: ${E1.Tax}\nNet salary: ${E1.CalcNet()}");
            Console.ReadLine();
        }
        public class Employee
        {
            //Private properties for the employee's name, gross salary and tax rate.
            private string name;
            private double gross;
            private double tax;
            //Default getters and setters for the properties
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Gross
            {
                get { return gross; }
                set { gross = value; }
            }
            public double Tax
            {
                get { return tax; }
                set { tax = value; }
            }
            //Constructor
            public Employee()
            {
                Console.WriteLine("***Employee record created***");
            }
            // CalcNet Method to calculate the net salary
            public double CalcNet()
            {
                return gross * (1 - tax / 100);
            }

        }
    }
}
