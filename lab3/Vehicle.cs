using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
        internal class Vehicle
        {
            public virtual void StartEngine()
            {
                Console.WriteLine("Vehicle engine started.");
            }

            public virtual void StopEngine()
            {
                Console.WriteLine("Vehicle engine stopped.");
            }
        }

        internal sealed class Car : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Car engine started.");
            }

            public override void StopEngine()
            {
                Console.WriteLine("Car engine stopped.");
            }
        }
        
        // The following class will cause a compile-time error because Car is sealed.
        // Uncommenting this will result in an error:
        /*
        internal class SportsCar : Car
        {
            // Error: 'Car' is sealed and cannot be inherited
        }
        */
    }
