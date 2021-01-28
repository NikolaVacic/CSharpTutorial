using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Nikola";
            string lastName = "Vacic";

            /* Ovaj nacin za spajanje stringova je los jer ce u memoriji prvo biti kreiran firstName + " " pa ce
            onda taj string biti dodat na lastName, ako bi to radili u nekoj petlji to bi bilo uzasno.*/
            string fullName = firstName + " " + lastName;

            // cw je snippet za kod ispot, cw pa dva puta tab.
            Console.WriteLine(fullName);

            //Mnogo je bolje ovako - interpolacija stringova
            fullName = $"{ firstName } { lastName }";

            Console.WriteLine(fullName);


            /*Mozemo koristiti @ ispred stringa kada zelimo da sve sto je u stringu budu deo stringa.
             Tj kada ne zelimo da stavljamo dva puta slash ili kada ne zelimo slucajne escape karaktere*/

            Console.WriteLine("\tab \\ sdsa");      // stampa "    ab \ sdsa"
            Console.WriteLine(@"\tab \\ sdsa");     // stampa "\tab \\ sdsa"


            // double vs decimal

            double wordsPerMinute = 23.34;
            decimal costPerContainer = 22.22M;

            // decimal MORA na kraju da ima M
            // decimal je precizniji od double sto znaci da zauzima vise memorije i vise vremena za kalkulaciju
            // pravilo: ako radimo sa novcem uvek treba koristiti decimal

        }

    }
}
