using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
        internal abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public abstract void Speak();
        }

        internal class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} the dog says: Woof!");
            }

            public void Fetch()
            {
                Console.WriteLine($"{Name} is fetching the ball.");
            }
        }

        internal class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} the cat says: Meow!");
            }

            public void Scratch()
            {
                Console.WriteLine($"{Name} is scratching the post.");
            }
        }
    }

