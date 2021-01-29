using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakpoints
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ove ugnjezdene petlje su namerno lose napisane da bi mogli da debaggujemo
            // Breakpoint nam omogucava da zaustavimo i zavirimo u aplikaciju u odredjenom trenutku
            // Breakpoint kaze aplikaciji da zeli da stane pre odredjene linije koda. 
            // Ne izvrsava je nego staje na toj liniji i dozvoljava nam da idemo kroz kod stepbystep kao sto kompajler radi.


            for (int i = 0; i < 20; ++i)
            {
                Console.WriteLine($"Vrednost od i je {i}");
                for (int j = 0; j < 10; ++i) 
                {
                    Console.WriteLine($"Vrednost od j je {j}");
                }
            }


            int suma = 0;

            for (int i = 0; i < 10; ++i) {
                suma += i * 5;
            }

            Console.WriteLine(suma);






        }
    }
}
