using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[3];       // moramo odrediti odmah koliku velicinu zelimo za niz
            int[] niz = new int[4];

            // nepotpunjena mesta u intovima ce biti 0, a u stringovima prazni stringovi

            cars[0] = "Audi";
            cars[1] = "BMW";
            cars[2] = "VW";

            // Parametar u Main funkciji je niz stringova koji se dobija kada se ovaj program poziva iz cmd-a.
            // nesto ovako: mainApp.exe /a /t /test /33

            string data = "Audi,BWM,VW,Ferrari";

            string[] carsData = data.Split(',');

            int[] brojevi = new int[] { 3, 6, 9 };      // jos jedan nacin za definisianje nizova


            // Liste su bolje od nizova

            List<string> listaStringova = new List<string>();

            listaStringova.Add("Fiat");
            listaStringova.AddRange(cars);      // dodavanje kolekcije

            Console.WriteLine(listaStringova[2]);

            listaStringova.Remove("BMW");           // kad obrisemo automatski ce biti siftovano sve 

            Console.WriteLine(listaStringova[2]);

            List<int> listaBrojeva = new List<int>() { 3, 4, 5 };     // moguce je i ovako definisati

            Console.WriteLine(listaBrojeva[2]);

            // Dictionary skladisti vrednost pod odredjenim kljucem. Dictionary<TKey, TValue>
            Dictionary<int, string> years = new Dictionary<int, string>();

            years[1389] = "Boj na kosovu";
            years[1981] = "Prvi PC racunari";
            years[1969] = "Prvi korak coveka na mesecu";
            years[1997] = "Ja sam rodjen";


            Console.WriteLine($"1969 se desilo ovo: {years[1969]}");
            // ako damo neki Key za koji vrednost ne postoji dobicemo exception
            // takodje ako damo novu vrednost pod istim kljucem override-ovacemo staru vrednost. Kljucevi su jedinstveni

        }
    }
}
