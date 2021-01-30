using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exception je kada kod uradi nesto neocekivano, nesto sto kompajler ne moze da obradi
// Kada se unhandled exception desi korisno je pogledati u view details sledece 3 stvari:
/*
    1. Message - daje opis exception-a
    2. Inner Exception - reci ce nam da li se exception desio u parent metodu, ako nije dace null.
    3. StackTrace - daje nam informaciju gde se tacno desio exception
 
 */

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadCall1();
            //BadCall2();
            //BadCall3();
            try
            {
                //BadCall4();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Desio se exception", ex);

            }

            try
            {
                //BadCall5();
            }
            catch (Exception ex)
            {


            }


            //---------------------------------------------------------------

            /*
             Moze postojati vise catch blokova za exceptione i uvek treba ici od specificnih ka opstijima, jer ce prvi
            catch blok koji hvata odgovarajuci exception biti izvrsen i nijedan vise.
            Finally blok ce uvek biti izvrsen
            
            Kada autogenerisemo neku funkciju ona ce biti generisana sa NotImplementedExceptionom u kodu da bi nam podsetila
            da nismo implementirali funkciju.

            Ako hoverujemo preko neke funkcije, builtin funkcije, onda mozemo videti koji tip exceptiona baca

            Poslednja stvar je mozemo filtrirati exception koristeci kljucnu rec when

             */

            int age = 20;

            try
            {
                //RandomFunkcija();
                //MatematickaFunkcija(-5);
                Godine();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Izvrsava se exception iz bloka koji hvata NotImplementedException");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex) when (age < 18)
            {
                // Hvatamo Invalid operation Exception kada je age < 18
                Console.WriteLine("Izvrsava se exception iz bloka koji hvata InvalidOperationException");
                Console.WriteLine(ex.Message);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Izvrsava se exception iz bloka koji hvata ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Izvrsava se exception iz bloka koji hvata Exception, opsteg bloka");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Finally blok ce uvek biti pokrenut bez obrzira da li je exception uhvacen ili ne");
                Console.WriteLine("Finally blok je dobar za oslobadjanje podataka ili zatvaranje fajlova/konekcija itd...");
            }

        }

        private static void Godine()
        {
            throw new InvalidOperationException("Exception se desio");
        }

        private static void MatematickaFunkcija(int v)
        {
            if (v < 0)
                throw new ArgumentException("Argument mora biti pozitivan broj");
        }

        private static void RandomFunkcija()
        {
            throw new NotImplementedException("Funkcija nije implementirana");
        }

        static void BadCall1()
        {
            int[] niz = new int[] { 1, 2, 3, 4, 5 };

            // namerno lose napisana petlja
            for (int i = 0; i <= niz.Length; ++i)
            {
                Console.WriteLine($"{niz[i]} ");

            }
        }
        static void BadCall2()
        {
            int[] niz = new int[] { 1, 2, 3, 4, 5 };

            // namerno lose napisana petlja
            for (int i = 0; i <= niz.Length; ++i)
            {
                try
                {
                    Console.WriteLine($"{niz[i]} ");
                }
                catch (Exception)
                {
                    // Ovim pristupom kazemo da se desila greska ali nista ne radimo sa exceptionom
                    Console.WriteLine("Desila se greska");

                }

            }
        }

        static void BadCall3()
        {
            int[] niz = new int[] { 1, 2, 3, 4, 5 };

            // namerno lose napisana petlja
            for (int i = 0; i <= niz.Length; ++i)
            {
                try
                {
                    Console.WriteLine($"{niz[i]} ");
                }
                catch (Exception ex)
                {
                    // Ako imenujemo exception sa ex(kao sto je standard) onda mozemo raditi sa njime
                    Console.WriteLine("Desila se greska");
                    Console.WriteLine(ex);
                    //Console.WriteLine(ex.Message);

                }

            }
        }

        static void BadCall4()
        {
            int[] niz = new int[] { 1, 2, 3, 4, 5 };

            // namerno lose napisana petlja
            for (int i = 0; i <= niz.Length; ++i)
            {
                try
                {
                    Console.WriteLine($"{niz[i]} ");
                }
                catch (Exception ex)
                {
                    // ova komanda baca exception iz ovog metoda 'navise' u stackTrace-u i daje sansu nekoj drugoj metodi da ga obradi
                    // problem ako stavimo samo throw je taj sto necemo saznati gde se exception zaista desio
                    // Throw-om izlazimo iz metode odmah
                    throw;

                }

            }
        }

        static void BadCall5()
        {
            int[] niz = new int[] { 1, 2, 3, 4, 5 };

            // namerno lose napisana petlja
            for (int i = 0; i <= niz.Length; ++i)
            {
                try
                {
                    Console.WriteLine($"{niz[i]} ");
                }
                catch (Exception ex)
                {
                    // Ako koristimo ovu metodu znacemo liniju koda u kojoj se desila greska u stacktrace-u
                    // Ova komanda takodje baca exception
                    throw new Exception("Desila se greska", ex);


                }

            }
        }

    }

}
