using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koliko imas godina: ");

            string age = Console.ReadLine();

            Console.WriteLine($"Za 5 godina ces imati { age + 5} godina");


            // Postoji bezbedan i nebezbedan nacin i zavisi od poverenja u input korisnika.

            // Ako verujemo korisniku:

            // problem sa ovim pristupom je taj sto ako ukucamo npr 'dvadeset' slovima dobicemo exception

            int godineNebezbedno = int.Parse(age);

            Console.WriteLine($"Za 5 godina ces imati { godineNebezbedno + 5 } godina");


            // bezbedan nacin

            bool validneGodine = int.TryParse(age, out int godineBezbedno);

            if (validneGodine)
                Console.WriteLine($"Za 5 godina ces imati { godineBezbedno + 5 } godina");
            else
                Console.WriteLine("Unesi godine u brojevima");

            // Mantra: Nikad ne veruj korisniku da ce uneti ispravne podatke.

            // tryParse postoji za (verovatno) svaki tip podataka.

            Console.WriteLine("Bool parse primer, da li si stariji od 20 godina? ");
            string odgovor = "";

            odgovor = Console.ReadLine();

            bool validanOdgovor = bool.TryParse(odgovor, out bool odg);

            if(validanOdgovor)
                Console.WriteLine(odg);
            else
                Console.WriteLine("Odgovori sa true/false ");

        }
    }
}
