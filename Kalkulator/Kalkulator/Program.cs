using System;

namespace Kalkulator
{
    class Program
    {
        decimal waga;
        decimal wzrost;
        decimal kalorie;
        decimal aktywnosc;
        decimal woda;
        


        static void Main(string[] args)
        {
            decimal waga;
            int wiek;
            decimal wzrost;
            decimal kalorie;
            decimal aktywnosc;
            decimal woda;
            string plec;
            string menu = "";
            


            Console.WriteLine("KALKULATOR ZAPOTRZEBOWANIA KALORYCZNEGO!");
            Console.WriteLine("----------------------------------------");

            do
            {
                Console.WriteLine("\nPodaj swoja plec, (M) jako mezczyzna lub (K) jako kobieta: ");
                plec = Console.ReadLine().ToUpper();
                if (plec == "M")
                {
                    plec = "mezczyzna";
                }
                else if(plec == "K")
                {
                    plec = "kobieta";
                }
                Console.WriteLine("Wpisz swoja wage w (kg): ");
                waga = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swoj wiek w (latach): ");
                wiek = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swoj wzrost w (cm): ");
                wzrost = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine($"Twoja plec to { plec}, ważysz {waga} kg, masz {wiek} lat oraz Twoj wzrost wynosi {wzrost} cm.");
                Console.WriteLine("Czy wszystko sie zgadza? Jesli chcesz wpisac swoje dane od poczatku wpisz (N), jesli nie, nacisnij (ENTER)");
                menu = Console.ReadLine().ToUpper();

            } while (menu == "N");

            Console.WriteLine("\nOKRESLANIE TWOJEJ AKTYWNOSCI:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nTWOJA AKTYWNOSC W SZKOLE LUB PRACY: ");
            Console.WriteLine("a) Bardzo lekka(siedzenie przez wiekszosc czasu na krzesle)." + "\nb) Lekka(lekkie fizyczne prace biurowe lub inne)." + 
                "\nc) Srednia(wieksza aktywnosc fizyczna typu czeste spacery lub psychiczna)" + "\nd) Wielka(ciezka fizyczna praca np na budowie, farmie lub innych tego typu)");






        }
    }
}
