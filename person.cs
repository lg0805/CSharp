using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_if_else
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}