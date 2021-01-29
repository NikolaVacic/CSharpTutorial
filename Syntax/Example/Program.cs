using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            bool isValidAge = int.TryParse(age, out int ages);

            if (isValidAge)
            {
                if (name.ToLower() == "bob" || name.ToLower() == "sue")
                {
                    if (ages < 21)
                    {
                        Console.WriteLine($"Hello Professor { name }, you should wait {21 - ages } years before you join this class");
                    }
                    else
                    {
                        Console.WriteLine($"Welcome Professor { name }");
                    }
                }
                else if (ages < 21)
                {
                    Console.WriteLine($"Hello {name}, you should wait {21 - ages} years before you join this class");
                }
                else {
                    Console.WriteLine($"Hello {name}. Welcome to the class");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid age first (in number form)");
            }

        }
    }
}
