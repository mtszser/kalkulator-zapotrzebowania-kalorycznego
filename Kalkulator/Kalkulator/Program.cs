using Microsoft.VisualBasic.CompilerServices;
using System;
using CalculatorLib;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Kalkulator
{

    class Program
    {
        static void BMI()
        {
            BMI bmi = new BMI();

            // Poczatek i podstawowe informacje

            Console.WriteLine("\nKALKULATOR BMI!");
            Console.WriteLine("Kalkulator BMI sprawdza proporcje miedzy Twoja masa ciala, a wzrostem i określa czy waga jest prawidłowa.");
            Console.WriteLine("Licznik BMI podaje wynik według podstawowej kwalifikacji dla dorosłych mężczyzn i kobiet." + "\nChcesz wiedzieć więcej? Jeśli tak, wpisz (T), jeśli nie, wpisz cokolwiek lub wciśnij (ENTER)");
            
            if (Console.ReadLine().ToUpper() == "T")
            {
                Console.WriteLine(bmi.getInfo());
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            // Zbieranie danych na temat osoby
            
            do
            {
                Console.WriteLine("Wpisz swoj wzrost w (cm): ");
                bmi.setHeight(Double.Parse(Console.ReadLine()));
                Console.WriteLine("Wpisz swoja wage w (kg):");
                bmi.setWeight(Double.Parse(Console.ReadLine()));

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine("Twoj wzrost wynosi " + Math.Round(bmi.getHeight(), 1) + " cm, a waga " + Math.Round(bmi.getWeight(), 1) + "kg. Czy wszystko sie zgadza?");
                Console.WriteLine("Jesli chcesz wpisac swoje dane od poczatku wpisz (N), jesli nie, nacisnij (ENTER)");
                

            } while (Console.ReadLine().ToUpper() == "N");

            // Obliczenia BMI

            bmi.setHeight(bmi.getHeight() / 100);
            bmi.setResult(bmi.getWeight() / Math.Pow(bmi.getHeight(), 2));

            // Określanie BMI
            
            if (bmi.getResult() < 18.5)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o niedowadze!");
            }
            else if (bmi.getResult() >= 18.5 & bmi.getResult() <= 24.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o prawidlowej masie ciala.");
            }
            else if (bmi.getResult() >= 25 & bmi.getResult() <= 29.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o nadwadze!");
            }
            else if (bmi.getResult() >= 30 & bmi.getResult() <= 34.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o otylosci I stopnia!");
            }
            else if (bmi.getResult() >= 35 & bmi.getResult() <= 39.9)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o otylosci II stopnia!!");
            }
            else if (bmi.getResult() >= 40)
            {
                Console.WriteLine("Twoje BMI wynosi " + Math.Round(bmi.getResult(), 2) + " co swiadczy o otylosci III stopnia!!!");
            }
        }

        static void BMR()
        {
            BMR bmr = new BMR();

            // Poczatek i podstawowe informacje

            Console.WriteLine("\nKALKULATOR ZAPOTRZEBOWANIA KALORYCZNEGO!");
            Console.WriteLine("Kalkulator BMR oblicza ilosc kalorii jaka powinienes/as spozywac w ciagu dnia," +
                "\nzeby podstrzymac podstawowe funkcje zyciowe." +
                "\nKalkulator TDEE oblicza ilosc kalorii jaka powinienes/as spozywac po uwzglednieniu Twojej aktywnosci ");
            Console.WriteLine("------------------------------------------------------------------");

            // Zbieranie danych na temat osoby

            do
            {
                Console.WriteLine("\nPodaj swoja plec, (M) jako mezczyzna lub (K) jako kobieta: ");

                string sex = (Console.ReadLine().ToUpper());

                if (sex == "M")
                {
                    bmr.setSex("mezczyzna");
                }
                else if(sex == "K")
                {
                    bmr.setSex("kobieta");
                }
                else
                {
                    Console.WriteLine("\nWPISALES NIEPRAWIDLOWE DANE!");
                    BMR();
                };
                Console.WriteLine("Wpisz swoja wage w (kg): ");
                bmr.setWeight(double.Parse(Console.ReadLine()));

                Console.WriteLine("Podaj swoj wiek w (latach): ");
                bmr.setAge(int.Parse(Console.ReadLine()));

                Console.WriteLine("Podaj swoj wzrost w (cm): ");
                bmr.setHeight(double.Parse(Console.ReadLine()));

                Console.WriteLine("\nPODSUMOWANIE:");
                Console.WriteLine("-------------");

                Console.WriteLine($"Twoja plec to {bmr.getSex()}, ważysz {Math.Round(bmr.getWeight())} kg, masz {bmr.getAge()} lat(a) oraz Twoj wzrost wynosi {Math.Round(bmr.getHeight())} cm.");
                Console.WriteLine("Czy wszystko sie zgadza? Jesli chcesz wpisac swoje dane od poczatku wpisz (N), \njeśli nie, wpisz cokolwiek lub wciśnij (ENTER)");
                

            } while (Console.ReadLine().ToUpper() != "");

            // Okreslanie aktywnosci dla poszczegolnej płci
            //Przypisywanie aktywnosci dla mezczyzny

            if (bmr.getSex() == "mezczyzna")
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
                    bmr.setActivity(double.Parse(Console.ReadLine()));

                    //przypisywanie wartosci do wybranej aktywnosci

                    switch (bmr.getActivity())
                    {
                        case 1:
                            bmr.setActivity(1.2);
                            break;
                        case 2:
                            bmr.setActivity(1.375);
                            break;
                        case 3:
                            bmr.setActivity(1.55);
                            break;
                        case 4:
                            bmr.setActivity(1.725);
                            break;
                        case 5:
                            bmr.setActivity(1.9);
                            break;
                    }

                    // Podstawienie do wzoru i obliczenie BMR za pomocą wzoru Mifflina
                    // PPM(mężczyźni) = (10 x masa ciała[kg])+(6,25 x wzrost[cm])-(5 x[wiek]) +5

                    bmr.setResult((10 * bmr.getWeight()) + (6.25 * bmr.getHeight()) - (5 * bmr.getAge()) + 5);



                    Console.WriteLine("\nCzy wszystko sie zgadza? Jesli tak, wpisz cokolwiek lub wcisnij (ENTER), jesli nie, wpisz (N).");
                } while(Console.ReadLine().ToUpper() != "");
            }

            //Przypisywanie aktywnosci dla kobiety

            else if (bmr.getSex() == "kobieta")
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

                    bmr.setActivity(double.Parse(Console.ReadLine()));

                    //przypisywanie wartosci do wybranej aktywnosci

                    switch(bmr.getActivity())
                    {
                        case 1:
                            bmr.setActivity(1.1);
                            break;
                        case 2:
                            bmr.setActivity(1.275);
                            break;
                        case 3:
                            bmr.setActivity(1.35);
                            break;
                        case 4:
                            bmr.setActivity(1.525);
                            break;
                        default:
                            Console.WriteLine("WYBIERZ ODPOWIEDNIA WARTOSC!");
                            break;

                    }
                    // Podstawienie do wzoru i obliczenie BMR za pomocą wzoru Mifflina
                    // PPM (kobiety) =  (10 x masa ciała[kg])+(6,25 x wzrost[cm])-(5 x [wiek]) – 161
                    bmr.setResult((10 * bmr.getWeight()) + (6.25 * bmr.getHeight()) - (5 * bmr.getAge()) - 161);

                    Console.WriteLine("\nCzy wszystko sie zgadza? Jesli tak, wpisz cokolwiek lub wcisnij (ENTER), jesli nie, wpisz (N).");
                } while(Console.ReadLine().ToUpper() != "");
            }


            Console.WriteLine("\nA teraz oblicze Twoje BMR:");
            Console.WriteLine("..TRWA LICZENIE..");
            Console.WriteLine("\n\nTwoje BMR wynosi: " + Math.Round(bmr.getResult(), 2) + " kcal.");
            Console.WriteLine("A teraz dodam do tego wspolczynnik aktywnosci, ktory podales/as wczesniej.");

            // wzor na TDEE

            bmr.setResult(bmr.getResult() * bmr.getActivity());

            Console.WriteLine("\nTwoje TDEE wynosi " + Math.Round(bmr.getResult(), 2) + " kcal. \nTDEE - Jest to ilosc kalorii jaka powinienes/as spozywac w ciagu dnia zakladajac Twoja aktywnosc");

        }
        static void Main(string[] args)
        {
            string menu = "";

            // Podstawowe menu

            do
            {
                Console.WriteLine("\nPROJEKT APLIKACJI KONSOLOWEJ C# ");
                Console.WriteLine("\nWpisz (1) jeśli chcesz przejść do kalkulatora BMI: " + "\nWpisz (2) jeśli chcesz przejść do kalkulatora BMR + TDEE: " + "\n\n\nWpisz (0) jesli chcesz wyjsc: ");
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
