using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // do while i while petlje su iste kao i u C++-u. Razlika je sto do while moze ici 1 ili vise puta, a 
            // while moze ici 0 ili vise puta.

            // for loop je takodje isto kao u C++

            int[] nizIntova = new int[] { 2, 3, 4, 1, 5, 6, 7 };


            // foreach ne postoji u C++ ali nije nista novo.
            // Svaka kolekcija koja implementira IEnumerable  interfejs omogucava foreach iteraciju
            foreach (int broj in nizIntova)
            {
                Console.WriteLine(broj);
            }

            Dictionary<int, string> years = new Dictionary<int, string>();

            years.Add(1389, "Boj na Kosovu");
            years[1981] = "Prvi PC racunari";
            years.Add(1969, "Prvi korak coveka na mesecu");
            years[1997] = "Ja sam rodjen";


            foreach (KeyValuePair<int, string> year in years)
            {
                Console.WriteLine($"{year.Key}: {year.Value}");
            }

        }
    }
}
