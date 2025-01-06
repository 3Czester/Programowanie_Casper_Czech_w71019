/*
using System;
using System.Collections.Generic;

namespace Kalkulator
{
    
    enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mnożenie,
        Dzielenie
    }

    class Program
    {
       
        static List<double> wyniki = new List<double>();

        static void Main(string[] args)
        {
            bool kontynuuj = true;

            while (kontynuuj)
            {
                try
                {
                    
                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Wyjście");

                    int wybor = int.Parse(Console.ReadLine());

                    
                    if (wybor < 1 || wybor > 5)
                    {
                        Console.WriteLine("Nieprawidłowy wybór operacji.");
                        continue;
                    }

                    if (wybor == 5)
                    {
                        kontynuuj = false;
                        break;
                    }

                    
                    Console.Write("Podaj pierwszą liczbę: ");
                    double liczba1 = double.Parse(Console.ReadLine());

                    Console.Write("Podaj drugą liczbę: ");
                    double liczba2 = double.Parse(Console.ReadLine());

                    Operacja operacja = (Operacja)(wybor - 1);
                    double wynik = 0;

                    
                    switch (operacja)
                    {
                        case Operacja.Dodawanie:
                            wynik = liczba1 + liczba2;
                            break;
                        case Operacja.Odejmowanie:
                            wynik = liczba1 - liczba2;
                            break;
                        case Operacja.Mnożenie:
                            wynik = liczba1 * liczba2;
                            break;
                        case Operacja.Dzielenie:
                            if (liczba2 == 0)
                            {
                                throw new DivideByZeroException("Nie można dzielić przez zero!");
                            }
                            wynik = liczba1 / liczba2;
                            break;
                    }

                    
                    wyniki.Add(wynik);

                    
                    Console.WriteLine($"Wynik: {wynik}");

                    
                    Console.WriteLine("\nWyniki poprzednich obliczeń:");
                    foreach (var w in wyniki)
                    {
                        Console.WriteLine(w);
                    }

                    Console.WriteLine(); // Przerwa
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Proszę wprowadzić prawidłową liczbę!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
                }
            }

            Console.WriteLine("Koniec programu.");
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;

namespace SklepZamowienia
{
    
    enum StatusZamowienia
    {
        Oczekujące,
        Przyjęte,
        Zrealizowane,
        Anulowane
    }

    class Program
    {
        
        static Dictionary<int, List<string>> zamowienia = new Dictionary<int, List<string>>();
        
        static Dictionary<int, StatusZamowienia> statusyZamowien = new Dictionary<int, StatusZamowienia>();

        static void Main(string[] args)
        {
           
            DodajZamowienie(1, new List<string> { "Produkt1", "Produkt2" });
            DodajZamowienie(2, new List<string> { "Produkt3" });
            DodajZamowienie(3, new List<string> { "Produkt4", "Produkt5", "Produkt6" });

            
            bool kontynuuj = true;

            while (kontynuuj)
            {
                Console.WriteLine("1. Zmień status zamówienia");
                Console.WriteLine("2. Wyświetl wszystkie zamówienia");
                Console.WriteLine("3. Zakończ");

                try
                {
                    int wybor = int.Parse(Console.ReadLine());

                    switch (wybor)
                    {
                        case 1:
                            ZmienStatusZamowienia();
                            break;

                        case 2:
                            WyswietlZamowienia();
                            break;

                        case 3:
                            kontynuuj = false;
                            break;

                        default:
                            Console.WriteLine("Nieprawidłowy wybór.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Proszę wprowadzić poprawny numer.");
                }
            }

            Console.WriteLine("Koniec programu.");
        }

        
        static void DodajZamowienie(int numerZamowienia, List<string> produkty)
        {
            zamowienia[numerZamowienia] = produkty;
            statusyZamowien[numerZamowienia] = StatusZamowienia.Oczekujące;
        }

        
        static void ZmienStatusZamowienia()
        {
            Console.Write("Podaj numer zamówienia: ");
            int numerZamowienia = int.Parse(Console.ReadLine());

            try
            {
                
                if (!zamowienia.ContainsKey(numerZamowienia))
                {
                    throw new KeyNotFoundException("Zamówienie o podanym numerze nie istnieje.");
                }

                Console.WriteLine("Wybierz nowy status:");
                Console.WriteLine("1. Oczekujące");
                Console.WriteLine("2. Przyjęte");
                Console.WriteLine("3. Zrealizowane");
                Console.WriteLine("4. Anulowane");

                int wybor = int.Parse(Console.ReadLine());

                StatusZamowienia nowyStatus = (StatusZamowienia)(wybor - 1);

                
                if (statusyZamowien[numerZamowienia] == nowyStatus)
                {
                    throw new ArgumentException("Zamówienie już ma ten status.");
                }

                
                statusyZamowien[numerZamowienia] = nowyStatus;
                Console.WriteLine($"Status zamówienia {numerZamowienia} zmieniono na {nowyStatus}.");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Proszę wybrać poprawny numer statusu.");
            }
        }

        
        static void WyswietlZamowienia()
        {
            foreach (var zamowienie in zamowienia)
            {
                int numerZamowienia = zamowienie.Key;
                List<string> produkty = zamowienie.Value;
                StatusZamowienia status = statusyZamowien[numerZamowienia];

                Console.WriteLine($"Numer zamówienia: {numerZamowienia}");
                Console.WriteLine($"Status: {status}");
                Console.WriteLine("Produkty:");
                foreach (var produkt in produkty)
                {
                    Console.WriteLine($"- {produkt}");
                }
                Console.WriteLine();
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;

namespace GraZGadujKolor
{
    
    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        Żółty,
        Fioletowy
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Kolor> kolory = new List<Kolor>
            {
                Kolor.Czerwony,
                Kolor.Niebieski,
                Kolor.Zielony,
                Kolor.Żółty,
                Kolor.Fioletowy
            };

            
            Random rand = new Random();
            Kolor wylosowanyKolor = kolory[rand.Next(kolory.Count)];

            
            bool odgadnięto = false;
            Console.WriteLine("Witaj w grze! Zgadnij kolor.");

            while (!odgadnięto)
            {
                Console.WriteLine("Dostępne kolory: Czerwony, Niebieski, Zielony, Żółty, Fioletowy");
                Console.Write("Wpisz kolor: ");

                string input = Console.ReadLine();

                try
                {
                    
                    Kolor kolorUzytkownika;
                    if (Enum.TryParse(input, true, out kolorUzytkownika))
                    {
                        if (Enum.IsDefined(typeof(Kolor), kolorUzytkownika))
                        {
                            
                            if (kolorUzytkownika == wylosowanyKolor)
                            {
                                Console.WriteLine("Brawo! Zgadłeś kolor.");
                                odgadnięto = true;
                            }
                            else
                            {
                                Console.WriteLine("Niestety, to nie ten kolor. Spróbuj ponownie.");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Nieprawidłowy kolor. Wybierz jeden z dostępnych kolorów.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Nieprawidłowy kolor. Wybierz jeden z dostępnych kolorów.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            Console.WriteLine("Koniec gry. Dziękujemy za udział!");
        }
    }
}
