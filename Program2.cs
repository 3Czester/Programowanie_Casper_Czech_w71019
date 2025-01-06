/*
using System;

class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;

   
    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    
    public string Imie
    {
        get { return imie; }
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Imię musi mieć co najmniej 2 znaki.");
            }
            imie = value;
        }
    }

    
    public string Nazwisko
    {
        get { return nazwisko; }
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Nazwisko musi mieć co najmniej 2 znaki.");
            }
            nazwisko = value;
        }
    }

   
    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Wiek musi być liczbą dodatnią.");
            }
            wiek = value;
        }
    }

    
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Osoba osoba = new Osoba("Jan", "Kowalski", 30);
            osoba.WyswietlInformacje();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}
*/
/*
using System;

public class BankAccount
{
    // Prywatne pole przechowujące saldo
    private decimal saldo;

    // Właściwość do odczytu salda
    public decimal Saldo
    {
        get { return saldo; }
    }

    // Właściwość przechowująca właściciela konta
    public string Wlasciciel { get; private set; }

    // Konstruktor, który inicjalizuje właściciela oraz początkowe saldo
    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }

    // Metoda wpłaty, która zwiększa saldo o określoną kwotę
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wpłaty musi być większa niż 0.");
        }
        else
        {
            saldo += kwota;
            Console.WriteLine($"Wpłacono: {kwota}. Nowe saldo: {saldo}");
        }
    }

    // Metoda wypłaty, która sprawdza, czy saldo jest wystarczające
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wypłaty musi być większa niż 0.");
        }
        else if (kwota > saldo)
        {
            Console.WriteLine("Niewystarczające środki na koncie.");
        }
        else
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłacono: {kwota}. Nowe saldo: {saldo}");
        }
    }
}

// Przykład użycia
class Program
{
    static void Main()
    {
        // Tworzymy nowe konto bankowe
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);

        // Wykonujemy wpłatę
        konto.Wplata(500);

        // Wykonujemy wypłatę
        konto.Wyplata(200);

        // Wyświetlamy saldo
        Console.WriteLine($"Saldo: {konto.Saldo}");
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    // Pola przechowujące imię, nazwisko i tablicę ocen
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    private List<int> oceny;

    // Konstruktor inicjujący imię i nazwisko
    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    // Właściwość obliczająca średnią ocen
    public double SredniaOcen
    {
        get
        {
            if (oceny.Count == 0) // jeśli brak ocen, zwróć 0
                return 0;
            return oceny.Average(); // oblicz średnią
        }
    }

    // Metoda dodająca ocenę do tablicy
    public void DodajOcene(int ocena)
    {
        if (ocena >= 2 && ocena <= 5) // Zakładając, że oceny są w przedziale od 2 do 5
        {
            oceny.Add(ocena);
            Console.WriteLine($"Dodano ocenę: {ocena}");
        }
        else
        {
            Console.WriteLine("Ocena musi być w przedziale od 2 do 5.");
        }
    }

    // Metoda wypisująca dane studenta
    public void WypiszDane()
    {
        Console.WriteLine($"Student: {Imie} {Nazwisko}");
        Console.WriteLine($"Średnia ocen: {SredniaOcen:F2}");
    }
}

// Przykład użycia klasy
class Program
{
    static void Main()
    {
        // Tworzymy nowego studenta
        Student student = new Student("Jan", "Kowalski");

        // Dodajemy oceny
        student.DodajOcene(5);
        student.DodajOcene(4);
        student.DodajOcene(3);

        // Wyświetlamy dane studenta
        student.WypiszDane();
    }
}
*/
/*
using System;

public class Licz
{
    // Prywatne pole przechowujące wartość liczbową
    private int value;

    // Konstruktor, który inicjalizuje pole 'value' przekazaną liczbą
    public Licz(int initialValue)
    {
        value = initialValue;
    }

    // Metoda Dodaj, która dodaje przekazaną wartość do 'value'
    public void Dodaj(int liczba)
    {
        value += liczba;
    }

    // Metoda Odejmij, która odejmuje przekazaną wartość od 'value'
    public void Odejmij(int liczba)
    {
        value -= liczba;
    }

    // Metoda do wypisania stanu obiektu (wartości 'value')
    public void WypiszStan()
    {
        Console.WriteLine($"Wartość: {value}");
    }
}

// Przykład użycia klasy Licz
class Program
{
    static void Main()
    {
        // Tworzymy kilka obiektów klasy Licz
        Licz licz1 = new Licz(10);
        Licz licz2 = new Licz(25);

        // Wypisujemy początkowe wartości
        licz1.WypiszStan(); // Wartość: 10
        licz2.WypiszStan(); // Wartość: 25

        // Wykonujemy operacje Dodaj i Odejmij
        licz1.Dodaj(5);
        licz1.Odejmij(3);

        licz2.Dodaj(10);
        licz2.Odejmij(5);

        // Wypisujemy nowe wartości
        licz1.WypiszStan(); // Wartość: 12
        licz2.WypiszStan(); // Wartość: 30
    }
}
*/
using System;

public class Sumator
{
    // Prywatne pole przechowujące tablicę liczb
    private int[] Liczby;

    // Konstruktor, który przyjmuje tablicę liczb i inicjalizuje pole
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    // Metoda Suma, zwracająca sumę wszystkich liczb w tablicy
    public int Suma()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    // Metoda SumaPodziel2, zwracająca sumę liczb podzielnych przez 2
    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    // Metoda IleElementów, zwracająca liczbę elementów w tablicy
    public int IleElementów()
    {
        return Liczby.Length;
    }

    // Metoda WypiszElementy, wypisująca wszystkie elementy tablicy
    public void WypiszElementy()
    {
        foreach (var liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    // Metoda WypiszElementyZZakresu, wypisująca elementy z określonego zakresu indeksów
    public void WypiszElementyZZakresu(int lowIndex, int highIndex)
    {
        // Sprawdzamy, aby indeksy mieściły się w poprawnym zakresie tablicy
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < Liczby.Length) // Sprawdzamy, czy indeks jest w granicach tablicy
            {
                Console.Write(Liczby[i] + " ");
            }
        }
        Console.WriteLine();
    }
}


class Program
{
    static void Main()
    {
        
        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Sumator sumator = new Sumator(liczby);

        
        Console.WriteLine("Wszystkie elementy:");
        sumator.WypiszElementy();

        
        Console.WriteLine($"Liczba elementów: {sumator.IleElementów()}");

        
        Console.WriteLine($"Suma wszystkich liczb: {sumator.Suma()}");

       
        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");

        
        Console.WriteLine("Elementy od indeksu 2 do 7:");
        sumator.WypiszElementyZZakresu(2, 7);

        
        Console.WriteLine("Elementy z zakresu -1 do 15:");
        sumator.WypiszElementyZZakresu(-1, 15);
    }
}
