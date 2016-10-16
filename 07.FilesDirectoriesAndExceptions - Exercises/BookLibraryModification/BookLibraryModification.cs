using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

public class BookLibraryModification
{
    public static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");
        int bookCounter = int.Parse(input[0]);

        Library library = new Library("My New Library");

        for (int i = 0; i < bookCounter; i++)
        {
            string inputLine = input[i + 1];
            string[] inputArgs = inputLine.Split(' ');
            string title = inputArgs[0];
            string author = inputArgs[1];
            string publisher = inputArgs[2];
            DateTime releaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string IsbnNumber = inputArgs[4];
            decimal price = decimal.Parse(inputArgs[5]);

            Book book = new Book(title, author, publisher, releaseDate, IsbnNumber, price);
            library.Books.Add(book);
        }

        DateTime sortedDate = DateTime.ParseExact(input[6], "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> booksByAuthors = new Dictionary<string, DateTime>();

        foreach (Book book in library.Books)
        {
            if (!booksByAuthors.ContainsKey(book.Title))
            {
                booksByAuthors.Add(book.Title, book.ReleaseDate);
            }
            else
            {
                booksByAuthors[book.Title] = book.ReleaseDate;
            }
        }

        foreach (var book in booksByAuthors.Where(x => x.Value > sortedDate).OrderBy(y => y.Value).ThenBy(s=>s.Key))
        {
            File.AppendAllText("output.txt", string.Format($"{book.Key} -> {book.Value.ToString("dd.MM.yyyy")}" + Environment.NewLine));
        }
    }
}

public class Book
{
    public Book(string title, string author, string publisher, DateTime releaseDate, string IsbnNumber, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        this.ReleaseDate = releaseDate;
        this.ISBNnumber = IsbnNumber;
        this.Price = price;
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBNnumber { get; set; }
    public decimal Price { get; set; }
}

public class Library
{
    public Library(string name)
    {
        this.Name = name;
        this.Books = new List<Book>();
    }

    public string Name { get; set; }
    public List<Book> Books { get; set; }
}