using System;
using System.ComponentModel.Design;

namespace Kalkulator
{
    class Program
    {
        static void BMI()
        {
            double waga;
            double wzrost;
            string menu = "";
            double BMI;

            Console.WriteLine("\nKALKULATOR BMI!");
            Console.WriteLine("Kalkulator BMI sprawdza zaleznosc proporcji miedzy Twoja masa ciala, a wzrostem.");
            Console.WriteLine("--------------------------------------------------------------------------------");

            do
            {
                Console.WriteLine("Wpisz swoj wzrost w (cm): ");
                wzrost = Double.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz swoja wage w (kg):");
                waga = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine($"Twoj wzrost to {wzrost} cm, a waga {waga} kg. Czy wszystko sie zgadza?");
                Console.WriteLine("Jesli chcesz wpisac swoje dane od poczatku wpisz (N), jesli nie, nacisnij (ENTER)");
                menu = Console.ReadLine().ToUpper();

            } while (menu == "N");

            wzrost = wzrost / 100;
            BMI = waga / Math.Pow(wzrost, 2);


            if (BMI < 18.5)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o niedowadze!");
            }
            else if (BMI >= 18.5 || BMI <= 24.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o prawidlowej masie ciala.");
            }
            else if (BMI >= 25 || BMI < 29.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o nadwadze!");
            }
            else if (BMI >= 30 || BMI < 34.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o otylosci I stopnia!");
            }
            else if (BMI >= 35 || BMI < 39.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o otylosci II stopnia!!");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o otylosci III stopnia!!!");
            }
        }

        static void BMR()
        {
            double waga;
            int wiek;
            double wzrost;
            double kalorie;
            double woda;
            string plec;
            string menu = "";
            double aktywnosc;

            


            Console.WriteLine("\nKALKULATOR ZAPOTRZEBOWANIA KALORYCZNEGO!");
            Console.WriteLine("Kalkulator zapotrzebowania kalorycznego oblicza ilosc kalorii, ktora powinno sie spozywac w ciagu dnia dla danej jednostki.");
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
                waga = Double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swoj wiek w (latach): ");
                wiek = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swoj wzrost w (cm): ");
                wzrost = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine($"Twoja plec to { plec}, ważysz {waga} kg, masz {wiek} lat oraz Twoj wzrost wynosi {wzrost} cm.");
                Console.WriteLine("Czy wszystko sie zgadza? Jesli chcesz wpisac swoje dane od poczatku wpisz (N), jesli nie, nacisnij (ENTER)");
                menu = Console.ReadLine().ToUpper();

            } while (menu == "N");

            Console.WriteLine("\nOKRESLANIE TWOJEJ AKTYWNOSCI:");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nTWOJA AKTYWNOSC W SZKOLE LUB PRACY: ");
            Console.WriteLine("1) Przy siedzącym trybie życia." + "\n2) Przy umiarkowanej aktywności fizycznej." +
                "\n3) Przy aktywnym trybie życia." + "\n4) Przy bardzo aktywnym trybie życia." + "\n5) Przy wyczynowym uprawianiu sportu.");
            aktywnosc = Double.Parse(Console.ReadLine());
            if(aktywnosc == 1)
            {
                aktywnosc = 1.4;
            }
            else if(aktywnosc == 2)
            {
                aktywnosc = 1.6;
            }
            else if(aktywnosc == 3)
            {
                aktywnosc = 1.75;
            }
            else if(aktywnosc == 4)
            {
                aktywnosc = 2.0;
            }
            else if(aktywnosc == 5)
            {
                aktywnosc = 2.2;
            }






        }
        static void Main(string[] args)
        {
            BMI();
            BMR();
        }
    }
}
