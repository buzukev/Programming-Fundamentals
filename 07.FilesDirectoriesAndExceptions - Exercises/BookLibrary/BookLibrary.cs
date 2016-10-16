using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
public class BookLibrary
{
    public static void Main()
    {
        string[] input = File.ReadAllLines("input.txt");

        int booksCount = int.Parse(input[0]);

        Library library = new Library("My Library");

        for (int i = 0; i < booksCount; i++)
        {
            string inputLine = input[i+1];
            string[] inputArgs = inputLine.Split(' ');
            string title = inputArgs[0];
            string author = inputArgs[1];
            string publisher = inputArgs[2];
            DateTime releaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbnNumber = inputArgs[4];
            decimal price = decimal.Parse(inputArgs[5]);

            Book book = new Book(title, author, publisher, releaseDate, isbnNumber, price);
            library.Books.Add(book);
        }

        Dictionary<string, List<Book>> booksByAuthors = new Dictionary<string, List<Book>>();

        foreach (Book book in library.Books)
        {
            if (!booksByAuthors.ContainsKey(book.Author))
            {
                booksByAuthors.Add(book.Author, new List<Book>());
            }

            booksByAuthors[book.Author].Add(book);
        }

        foreach (var author in booksByAuthors.OrderByDescending(x => x.Value.Select(y =>y.Price).Sum()).ThenBy(x => x.Key))
        {
            decimal totalPrice = author.Value.Select(x => x.Price).Sum();

            File.AppendAllText("output.txt", string.Format($"{author.Key} -> {totalPrice}" + Environment.NewLine));
        }

    }
}

public class Book
{
    public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Publisher = publisher;
        this.ReleaseDate = releaseDate;
        this.IsbnNumber = isbnNumber;
        this.Price = price;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string IsbnNumber { get; set; }
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