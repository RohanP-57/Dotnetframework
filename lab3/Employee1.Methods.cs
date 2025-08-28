using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
        internal partial class Employee1
        {
            public decimal CalculateGrossSalary()
            {
                return BaseSalary + Bonus;
            }

            public decimal CalculateNetSalary()
            {
                return CalculateGrossSalary() - Deductions;
            }
        }
    }
