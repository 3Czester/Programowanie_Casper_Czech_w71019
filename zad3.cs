/*
using System;

public class Person
{
    // Pola
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Konstruktor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Metoda View
    public void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Age}");
    }
}

public class Book
{
    // Pola
    public string Title { get; set; }
    public Person Author { get; set; }
    public DateTime PublicationDate { get; set; }

    // Konstruktor
    public Book(string title, Person author, DateTime publicationDate)
    {
        Title = title;
        Author = author;
        PublicationDate = publicationDate;
    }

    // Metoda View
    public void View()
    {
        Console.WriteLine($"Tytuł: {Title}, Autor: {Author.FirstName} {Author.LastName}, Data wydania: {PublicationDate.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy obiekty klasy Person
        Person author1 = new Person("Adam", "Kowalski", 45);
        Person author2 = new Person("Anna", "Nowak", 37);

        // Tworzymy obiekty klasy Book
        Book book1 = new Book("Wiedźmin", author1, new DateTime(2009, 5, 15));
        Book book2 = new Book("Harry Potter", author2, new DateTime(2001, 6, 26));

        // Wywołujemy metody View
        author1.View();
        author2.View();
        book1.View();
        book2.View();
    }
}
*/
/*
using System;
using System.Collections.Generic;

public class Reader : Person
{
    // Lista książek przeczytanych przez czytelnika
    public List<Book> ReadBooks { get; set; } = new List<Book>();

    // Konstruktor
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    // Metoda ViewBook wypisuje tytuły książek przeczytanych przez czytelnika
    public void ViewBook()
    {
        Console.WriteLine($"{FirstName} {LastName} przeczytał(a) następujące książki:");
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"- {book.Title}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy obiekty klasy Person
        Person author1 = new Person("Adam", "Kowalski", 45);
        Person author2 = new Person("Anna", "Nowak", 37);

        // Tworzymy obiekty klasy Book
        Book book1 = new Book("Wiedźmin", author1, new DateTime(2009, 5, 15));
        Book book2 = new Book("Harry Potter", author2, new DateTime(2001, 6, 26));

        // Tworzymy obiekty klasy Reader
        Reader reader1 = new Reader("Jan", "Kowalski", 25);
        Reader reader2 = new Reader("Marta", "Nowak", 30);

        // Dodajemy książki do listy przeczytanych przez czytelników
        reader1.ReadBooks.Add(book1);
        reader2.ReadBooks.Add(book1);
        reader2.ReadBooks.Add(book2);

        // Wywołujemy metodę ViewBook
        reader1.ViewBook();
        reader2.ViewBook();
    }
}
*/
/*
using System;

public class Reader : Person
{
    // Lista książek przeczytanych przez czytelnika
    public List<Book> ReadBooks { get; set; } = new List<Book>();

    // Konstruktor
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
    }

    // Metoda ViewBook wypisuje tytuły książek przeczytanych przez czytelnika
    public void ViewBook()
    {
        Console.WriteLine($"{FirstName} {LastName} przeczytał(a) następujące książki:");
        foreach (var book in ReadBooks)
        {
            Console.WriteLine($"- {book.Title}");
        }
    }

    // Metoda View wypisuje dane czytelnika oraz książki, które przeczytał
    public new void View()
    {
        base.View();
        ViewBook();
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy obiekty klasy Person
        Person author1 = new Person("Adam", "Kowalski", 45);
        Person author2 = new Person("Anna", "Nowak", 37);

        // Tworzymy obiekty klasy Book
        Book book1 = new Book("Wiedźmin", author1, new DateTime(2009, 5, 15));
        Book book2 = new Book("Harry Potter", author2, new DateTime(2001, 6, 26));

        // Tworzymy obiekty klasy Reader
        Reader reader1 = new Reader("Jan", "Kowalski", 25);
        Reader reader2 = new Reader("Marta", "Nowak", 30);

        // Dodajemy książki do listy przeczytanych przez czytelników
        reader1.ReadBooks.Add(book1);
        reader2.ReadBooks.Add(book1);
        reader2.ReadBooks.Add(book2);

        // Wywołujemy metodę View na obiektach typu Reader
        reader1.View();
        reader2.View();
    }
}
*/
/*
public class Person
{
    // Prywatne pola z właściwościami
    private string firstName;
    private string lastName;
    private int age;

    // Właściwości
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public int Age { get => age; set => age = value; }

    // Konstruktor
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Metoda View
    public void View()
    {
        Console.WriteLine($"Imię: {FirstName}, Nazwisko: {LastName}, Wiek: {Age}");
    }
}
*/
/*
using System;

public class Reviewer : Reader
{
    // Konstruktor
    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

    // Metoda Wypisz wypisuje książki i losowe oceny
    public void Wypisz()
    {
        Console.WriteLine($"{FirstName} {LastName} (recenzent) przeczytał(a) następujące książki:");
        Random random = new Random();
        foreach (var book in ReadBooks)
        {
            int rating = random.Next(1, 6); // Losowa ocena od 1 do 5
            Console.WriteLine($"- {book.Title}, Ocena: {rating}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy obiekty klasy Person
        Person author1 = new Person("Adam", "Kowalski", 45);
        Person author2 = new Person("Anna", "Nowak", 37);

        // Tworzymy obiekty klasy Book
        Book book1 = new Book("Wiedźmin", author1, new DateTime(2009, 5, 15));
        Book book2 = new Book("Harry Potter", author2, new DateTime(2001, 6, 26));

        // Tworzymy obiekty klasy Reviewer
        Reviewer reviewer1 = new Reviewer("Piotr", "Wojciechowski", 35);
        reviewer1.ReadBooks.Add(book1);
        reviewer1.ReadBooks.Add(book2);

        // Wywołujemy metodę Wypisz
        reviewer1.Wypisz();
    }
}
*/
/*
using System;

public class Samochod
{
    // Pola
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Nadwozie { get; set; }
    public string Kolor { get; set; }
    public int RokProdukcji { get; set; }
    public double Przebieg { get; set; }

    // Konstruktor przyjmujący dane od użytkownika
    public Samochod()
    {
        Console.WriteLine("Podaj markę samochodu:");
        Marka = Console.ReadLine();

        Console.WriteLine("Podaj model samochodu:");
        Model = Console.ReadLine();

        Console.WriteLine("Podaj typ nadwozia samochodu:");
        Nadwozie = Console.ReadLine();

        Console.WriteLine("Podaj kolor samochodu:");
        Kolor = Console.ReadLine();

        Console.WriteLine("Podaj rok produkcji samochodu:");
        RokProdukcji = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj przebieg samochodu:");
        Przebieg = double.Parse(Console.ReadLine());

        // Sprawdzamy, czy przebieg nie jest ujemny
        if (Przebieg < 0)
        {
            Console.WriteLine("Przebieg nie może być ujemny. Ustawiono przebieg na 0.");
            Przebieg = 0;
        }
    }

    // Przeciążony konstruktor
    public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
    {
        Marka = marka;
        Model = model;
        Nadwozie = nadwozie;
        Kolor = kolor;
        RokProdukcji = rokProdukcji;
        Przebieg = przebieg;

        // Sprawdzamy, czy przebieg nie jest ujemny
        if (Przebieg < 0)
        {
            Console.WriteLine("Przebieg nie może być ujemny. Ustawiono przebieg na 0.");
            Przebieg = 0;
        }
    }

    // Metoda wyświetlająca informacje o samochodzie
    public virtual void WyswietlInformacje()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Nadwozie: {Nadwozie}, Kolor: {Kolor}, Rok produkcji: {RokProdukcji}, Przebieg: {Przebieg} km");
    }
}

public class SamochodOsobowy : Samochod
{
    // Dodatkowe pola w klasie SamochodOsobowy
    public double Waga { get; set; }
    public double PojemnoscSilnika { get; set; }
    public int IloscOsob { get; set; }

    // Konstruktor klasy SamochodOsobowy
    public SamochodOsobowy() : base()
    {
        Console.WriteLine("Podaj wagę samochodu (w tonach):");
        Waga = double.Parse(Console.ReadLine());
        if (Waga < 2 || Waga > 4.5)
        {
            Console.WriteLine("Waga samochodu musi wynosić od 2 do 4,5 t. Ustawiono wagę na 2 t.");
            Waga = 2;
        }

        Console.WriteLine("Podaj pojemność silnika (w litrach):");
        PojemnoscSilnika = double.Parse(Console.ReadLine());
        if (PojemnoscSilnika < 0.8 || PojemnoscSilnika > 3.0)
        {
            Console.WriteLine("Pojemność silnika musi wynosić od 0,8 do 3,0 l. Ustawiono pojemność silnika na 0,8 l.");
            PojemnoscSilnika = 0.8;
        }

        Console.WriteLine("Podaj liczbę miejsc w samochodzie:");
        IloscOsob = int.Parse(Console.ReadLine());
    }

    // Przeciążona metoda wyświetlająca informacje o samochodzie osobowym
    public override void WyswietlInformacje()
    {
        base.WyswietlInformacje();
        Console.WriteLine($"Waga: {Waga} t, Pojemność silnika: {PojemnoscSilnika} l, Liczba miejsc: {IloscOsob}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzymy obiekt klasy SamochodOsobowy (korzystając z konstruktora bez parametrów)
        Console.WriteLine("Podaj dane dla samochodu osobowego:");
        SamochodOsobowy samochodOsobowy = new SamochodOsobowy();

        // Tworzymy dwa obiekty klasy Samochod (korzystając z różnych konstruktorów)
        Samochod samochod1 = new Samochod("Toyota", "Corolla", "Sedan", "Biały", 2020, 25000);
        Samochod samochod2 = new Samochod("Ford", "Focus", "Hatchback", "Czarny", 2018, 45000);

        // Wyświetlamy informacje o samochodach
        Console.WriteLine("\nInformacje o samochodach:");
        samochodOsobowy.WyswietlInformacje();
        samochod1.WyswietlInformacje();
        samochod2.WyswietlInformacje();
    }
}
*/