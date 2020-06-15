﻿using System;
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
            string kwalifikacja = "";

            // Poczatek i podstawowe informacje

            Console.WriteLine("\nKALKULATOR BMI!");
            Console.WriteLine("Kalkulator BMI sprawdza proporcje miedzy Twoja masa ciala, a wzrostem i określa czy waga jest prawidłowa.");
            Console.WriteLine("Licznik BMI podaje wynik według podstawowej kwalifikacji dla dorosłych mężczyzn i kobiet." + "\nChcesz wiedzieć więcej? Jeśli tak, wpisz (T), jeśli nie, wpisz cokolwiek lub wciśnij (ENTER)");
            kwalifikacja = Console.ReadLine().ToUpper();
            if (kwalifikacja == "T")
            {
                Console.WriteLine("Niedowaga: poniżej 18,5" + "\nPrawidłowa masa ciała: 18,5-24,9" + "\nNadwaga: 25,0-29,9" + "\notyłość I stopnia: 30,0-34,9" + "\notyłość II stopnia: 35,0-39,9"
                    + "\notyłość III stopnia: powyżej 40");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            // Zbieranie danych na temat osoby

            do
            {
                Console.WriteLine("Wpisz swoj wzrost w (cm): ");
                wzrost = Double.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz swoja wage w (kg):");
                waga = Double.Parse(Console.ReadLine());

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine("Twoj wzrost wynosi " + Math.Round(wzrost, 1) + " cm, a waga " + Math.Round(waga, 1) + "kg. Czy wszystko sie zgadza?");
                Console.WriteLine("Jesli chcesz wpisac swoje dane od poczatku wpisz (N), jesli nie, nacisnij (ENTER)");
                menu = Console.ReadLine().ToUpper();

            } while (menu == "N");

            // Obliczenia BMI

            wzrost = wzrost / 100;
            BMI = waga / Math.Pow(wzrost, 2);

            // Określanie BMI

            if (BMI < 18.5)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o niedowadze!");
            }
            else if (BMI >= 18.5 & BMI <= 24.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o prawidlowej masie ciala.");
            }
            else if (BMI >= 25 & BMI <= 29.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o nadwadze!");
            }
            else if (BMI >= 30 & BMI <= 34.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(BMI, 2) + " co swiadczy o otylosci I stopnia!");
            }
            else if (BMI >= 35 & BMI <= 39.9)
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
            string plec;
            string menu = "";
            double aktywnosc = 0;
            double BMR = 0;
            double TDEE = 0;
            


            // Poczatek i podstawowe informacje

            Console.WriteLine("\nKALKULATOR ZAPOTRZEBOWANIA KALORYCZNEGO!");
            Console.WriteLine("Kalkulator BMR oblicza ilosc kalorii jaka powinienes/as spozywac w ciagu dnia, zeby podstrzymac podstawowe funkcje zyciowe." +
                "\nKalkulator TDEE oblicza ilosc kalorii jaka powinienes/as spozywac po uwzglednieniu Twojej aktywnosci ");
            Console.WriteLine("------------------------------------------------------------------");

            // Zbieranie danych na temat osoby

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

                Console.WriteLine($"Twoja plec to { plec}, ważysz {waga} kg, masz {wiek} lat(a) oraz Twoj wzrost wynosi {wzrost} cm.");
                Console.WriteLine("Czy wszystko sie zgadza? Jesli chcesz wpisac swoje dane od poczatku wpisz (N), \njeśli nie, wpisz cokolwiek lub wciśnij (ENTER)");
                menu = Console.ReadLine().ToUpper();

            } while (menu == "N");

            // Okreslanie aktywnosci dla poszczegolnej
            if (plec == "mezczyzna")
            {
                do
                {
                    Console.WriteLine("\nOKRESLANIE TWOJEJ AKTYWNOSCI:");
                    Console.WriteLine("\nTWOJA AKTYWNOSC NA CODZIEN. \nWybierz numer, ktory odpowiada Twojej dziennej aktywnosci: ");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("\n1) Przy siedzącym trybie życia(kanapowiec)." + 
                        "\n2) Przy umiarkowanej aktywności fizycznej(lekka praca fizyczna lub umyslowa/ aktywność 1-3x w tygodniu)." +
                        "\n3) Przy aktywnym trybie życia(srednio fizyczna praca/ aktywność 3-5x w tygodniu)." + 
                        "\n4) Przy bardzo aktywnym trybie życia(ciezka fizyczna praca/ aktywność 6-7x w tygodniu." +
                        "\n5) Przy ekstremalnie aktywnym trybie zycia(bardzo ciezka fizyczna praca / cwiczenie nawet kilka razy dziennie.");

                    aktywnosc = Double.Parse(Console.ReadLine());
                    if (aktywnosc == 1)
                    {
                        aktywnosc = 1.2;
                    }
                    else if (aktywnosc == 2)
                    {
                        aktywnosc = 1.375;
                    }
                    else if (aktywnosc == 3)
                    {
                        aktywnosc = 1.55;
                    }
                    else if (aktywnosc == 4)
                    {
                        aktywnosc = 1.725;
                    }
                    else if (aktywnosc == 5)
                    {
                        aktywnosc = 1.9;
                    }

                    Console.WriteLine("\nCzy wszystko sie zgadza? Jesli tak, wpisz cokolwiek lub wcisnij (ENTER), jesli nie, wpisz (N).");
                    menu = Console.ReadLine().ToUpper();
                } while(menu == "N");
            }
            else if (plec == "kobieta")
            {
                do
                {
                    Console.WriteLine("\nOKRESLANIE TWOJEJ AKTYWNOSCI:");
                    Console.WriteLine("\nTWOJA AKTYWNOSC W SZKOLE LUB PRACY. \nWybierz numer, ktory odpowiada Twojej dziennej aktywnosci: ");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("\n1) Przy siedzącym trybie życia(kanapowiec)." + 
                        "\n2) Przy umiarkowanej aktywności fizycznej(lekka praca fizyczna lub umyslowa/ aktywność 1-3x w tygodniu)." +
                        "\n3) Przy aktywnym trybie życia(średnio fizyczna praca/ aktywnosc 3-5x w tygodniu)." + 
                        "\n4) Przy bardzo aktywnym trybie życia(ciezkie cwiczenia/ aktywność 6-7x w tygodniu.");

                    aktywnosc = Double.Parse(Console.ReadLine());
                    if (aktywnosc == 1)
                    {
                        aktywnosc = 1.1;
                    }
                    else if (aktywnosc == 2)
                    {
                        aktywnosc = 1.275;
                    }
                    else if (aktywnosc == 3)
                    {
                        aktywnosc = 1.35;
                    }
                    else if (aktywnosc == 4)
                    {
                        aktywnosc = 1.525;
                    }

                    Console.WriteLine("\nCzy wszystko sie zgadza? Jesli tak, wpisz cokolwiek lub wcisnij (ENTER), jesli nie, wpisz (N).");
                    menu = Console.ReadLine().ToUpper();
                } while(menu == "N") ;
            }

            // Podstawienie do wzoru i obliczenie BMR za pomocą wzoru Mifflina
            // PPM (kobiety) =  (10 x masa ciała[kg])+(6,25 x wzrost[cm])-(5 x [wiek]) – 161
            // PPM(mężczyźni) = (10 x masa ciała[kg])+(6,25 x wzrost[cm])-(5 x[wiek]) +5

            if(plec == "kobieta")
            {
                BMR = (10 * waga) + (6.25 * wzrost) - (5 * wiek) - 161;
            }
            else if(plec == "mezczyzna")
            {
                BMR = (10 * waga) + (6.25 * wzrost) - (5 * wiek) + 5;
            }

            Console.WriteLine("\nA teraz oblicze Twoje BMR:");
            Console.WriteLine("..TRWA LICZENIE..");
            Console.WriteLine("\n\nTwoje BMR wynosi: " + Math.Round(BMR, 2) + " kcal.");
            Console.WriteLine("A teraz dodam do tego wspolczynnik aktywnosci, ktory podales/as wczesniej.");

            // wzor na TDEE
            TDEE = BMR * aktywnosc;

            Console.WriteLine("\nTwoje TDEE wynosi " + Math.Round(TDEE, 2) + " kcal. \nTDEE - Jest to ilosc kalorii jaka powinienes/as spozywac w ciagu dnia zakladajac Twoja aktywnosc");

        }
        static void Main(string[] args)
        {
            string menu = "";

            // Podstawowe menu

            do
            {
                Console.WriteLine("\nPROJEKT APLIKACJI KONSOLOWEJ C# ");
                Console.WriteLine("\nWpisz (1) jeśli chcesz przejść do kalkulatora BMI: " + "\nWpisz (2) jeśli chcesz przejść do kalkulatora BMR + TDEE: " + "\nWpisz (0) jesli chcesz wyjsc: ");
                menu = Console.ReadLine();
                if (menu == "1")
                {
                    BMI();
                }
                else if (menu == "2")
                {
                    BMR();
                }
            } while (menu != "0");
                
            
            
        }
    }
}
