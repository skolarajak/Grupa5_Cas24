using System;
using System.IO;

namespace Cas24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1();
            Zadatak2();
            //Console.ReadKey();
        }

        static void Zadatak1()
        {
            Console.WriteLine("Unesi broj redova");
            var brRedova = System.Convert.ToInt32(Console.ReadLine());

            var brojac = 1;
            for (var i = 1; i <= brRedova; i++)
            {
                for (var j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", brojac);
                    brojac++;
                }
                Console.WriteLine();
            }
        }

        static void Zadatak2()
        {
            string odgovor;
            do
            {
                Console.Clear();
                Console.WriteLine("QA Telefonski Imenik\n");
                Console.WriteLine("1. Unos novog imena");
                Console.WriteLine("2. Listanje imena");
                Console.WriteLine("3. Pretraga");
                Console.WriteLine("Q. Kraj rada");
                odgovor = Console.ReadLine();

                if (odgovor == "1")
                {
                    UnosNovogImena();
                }

                if (odgovor == "2")
                {
                    ListanjeImena();
                }

                if (odgovor == "3")
                {

                }

            } while (odgovor.ToUpper() != "Q");
        }

        static void UnosNovogImena()
        {
            string ime, prezime, adresa, telefon, odgovor;
            do
            {
                Console.Write("Unesite ime >");
                ime = Console.ReadLine();
                Console.Write("Unesite prezime >");
                prezime = Console.ReadLine();
                Console.Write("Unesite adresu >");
                adresa = Console.ReadLine();
                Console.Write("Unesite telefon >");
                telefon = Console.ReadLine();
                FileManagement.Store(ime, prezime, adresa, telefon);
                Console.WriteLine("\nDa li zelite unos novog korisnika? Pritisnite \"D\" ukoliko zelite ili ENTER ako ne zelite");
                odgovor = Console.ReadLine();
                Console.WriteLine("");
            } while (odgovor.ToUpper() == "D");
        }

        static void ListanjeImena()
        {
            Console.Clear();
            string[] listOfNames = FileManagement.Read();
            string[] razbijenaOsoba;
            Console.WriteLine("Ime\tPrezime\tTelefon\tAdresa");
            Console.WriteLine("--------------------------------------------------");
            foreach (string osoba in listOfNames)
            {
                razbijenaOsoba = osoba.Split(';');
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", razbijenaOsoba[0], razbijenaOsoba[1], razbijenaOsoba[3], razbijenaOsoba[2]);
            }
            Console.ReadKey();
        }


    }
}
