using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
        internal class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }

            public void DisplayDetails()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Salary: {Salary:C}");
            }
        }
}
