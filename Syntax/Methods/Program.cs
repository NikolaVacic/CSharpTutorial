using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metod treba raditi jednu stvar
            // za davanje imena metodama se koristi pascal naming convention (prvo slovo svake reci je veliko slovo)
            // takodje konvencija je da metod ima deskriptivno ime.
            DobrodosaoPoruka();

            string ime = KakoSeZoves();

            DobrodosaoKorisnice(ime);

        }

        private static void DobrodosaoPoruka()
        {
            Console.WriteLine("Dobro Dosao u Methods Projekat");
            Console.WriteLine("Methods projekat se nalazi u Syntax solution-u");
            Console.WriteLine("Ja sam Nikola Vacic");
        }
        private static void DobrodosaoKorisnice(string firstName)
        {
            Console.WriteLine($"Dobro dosao {firstName}");
        }
        private static string KakoSeZoves()
        {
            Console.WriteLine("Kako se zoves?");
            string ime = Console.ReadLine();

            return ime;
        }


    }
}
