using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // if, else, else if, && i || je isto kao u C++.

            Console.Write("Unesi broj meseca u kojem si rodjen : ");
            
            int month;

            month = Convert.ToInt32(Console.ReadLine()); // ovako se mora inputovati int
 
            switch (month)
            {
                case 1: Console.WriteLine("Januar"); break;
                case 2: Console.WriteLine("Februar"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Maj"); break;
                case 6: Console.WriteLine("Jun"); break;
                case 7: Console.WriteLine("Jul"); break;
                case 8: Console.WriteLine("Avgust"); break;
                case 9: Console.WriteLine("Septembar"); break;
                case 10: Console.WriteLine("Oktobar"); break;
                case 11: Console.WriteLine("Novembar"); break;
                case 12: Console.WriteLine("Decembar"); break;
                default: Console.WriteLine("Unesi broj iz intervala [1,12]"); break;
            }


        }
    }
}
