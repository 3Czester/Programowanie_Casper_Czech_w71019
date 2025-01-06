/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.");


        Console.Write("Podaj współczynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współczynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Wyróżnik delta wynosi: {delta}");


        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Trójmian ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Trójmian ma jeden pierwiastek podwójny: x = {x}");
        }
        else
        {
            Console.WriteLine("Trójmian nie ma pierwiastków rzeczywistych (delta < 0). Pierwiastki są zespolone.");
        }


        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
*/
/*
using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nKalkulator - Wybierz opcję:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Różnica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Wyjście");

            Console.Write("Twój wybór: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Podaj pierwszą liczbę: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Suma: {num1 + num2}");
                    break;

                case 2:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Różnica: {num1 - num2}");
                    break;

                case 3:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {num1 * num2}");
                    break;

                case 4:
                    Console.Write("Podaj pierwszą liczbę: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Iloraz: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero.");
                    }
                    break;

                case 5:
                    Console.Write("Podaj podstawę: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj wykładnik: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Potęga: {Math.Pow(num1, num2)}");
                    break;

                case 6:
                    Console.Write("Podaj liczbę: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        Console.WriteLine($"Pierwiastek kwadratowy: {Math.Sqrt(num1)}");
                    }
                    else
                    {
                        Console.WriteLine("Błąd: Nie można obliczyć pierwiastka z liczby ujemnej.");
                    }
                    break;

                case 7:
                    Console.Write("Podaj kąt w radianach: ");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Sinus: {Math.Sin(angle)}");
                    Console.WriteLine($"Cosinus: {Math.Cos(angle)}");
                    Console.WriteLine($"Tangens: {Math.Tan(angle)}");
                    if (Math.Cos(angle) != 0)
                    {
                        Console.WriteLine($"Cotangens: {1 / Math.Tan(angle)}");
                    }
                    else
                    {
                        Console.WriteLine("Cotangens: Nieokreślony (cosinus = 0)");
                    }
                    break;

                case 8:
                    Console.WriteLine("Do widzenia!");
                    return;

                default:
                    Console.WriteLine("Błąd: Niepoprawny wybór.");
                    break;
            }
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];

        Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Wyświetl tablicę od pierwszego do ostatniego indeksu.");
            Console.WriteLine("2. Wyświetl tablicę od ostatniego do pierwszego indeksu.");
            Console.WriteLine("3. Wyświetl elementy o nieparzystych indeksach.");
            Console.WriteLine("4. Wyświetl elementy o parzystych indeksach.");
            Console.WriteLine("5. Wyjście.");

            Console.Write("Wybierz opcję: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nTablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nTablica od ostatniego do pierwszego indeksu:");
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nElementy o nieparzystych indeksach:");
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nElementy o parzystych indeksach:");
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Do widzenia!");
                break;
            }
            else
            {
                Console.WriteLine("Błąd: Niepoprawny wybór.");
            }
        } while (true);
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];

        Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczanie sumy elementów
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Suma elementów tablicy: {sum}");

        // Obliczanie iloczynu elementów
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        Console.WriteLine($"Iloczyn elementów tablicy: {product}");

        // Obliczanie średniej
        double average = sum / numbers.Length;
        Console.WriteLine($"Średnia wartość elementów tablicy: {average}");

        // Wyznaczanie wartości minimalnej
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"Minimalna wartość w tablicy: {min}");

        // Wyznaczanie wartości maksymalnej
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"Maksymalna wartość w tablicy: {max}");
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Liczby od 20 do 0 z pominięciem: 2, 6, 9, 15, 19:");

        for (int i = 20; i >= 0; i--)
        {
            // Pomijamy liczby 2, 6, 9, 15, 19
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowadź liczby całkowite. Wprowadzenie liczby ujemnej zakończy działanie programu.");

        while (true)
        {
            Console.Write("Podaj liczbę: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Wprowadzono liczbę ujemną. Zakończenie programu.");
                break;
            }

            Console.WriteLine($"Wprowadzono liczbę: {number}");
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile liczb chcesz wprowadzić? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Wprowadź liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sortowanie bąbelkowe
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Zamiana miejscami
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nPosortowane liczby:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/