using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public string ReleaseDate { get; set; }
    public string isbnNumber { get; set; }
    public double Price { get; set; }
}
public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

public class BookLibrary
{
    public static void Main()
    {
        Library Library = new Library();
        Library.Books = new List<Book>();

        int numberOfBooks = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfBooks; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string title = input[0];
            string author = input[1];
            string publisher = input[2];
            string releaseDate = input[3];
            string isbn = input[4];
            double price = double.Parse(input[5]);
            Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.ReleaseDate = releaseDate;
            book.isbnNumber = isbn;
            book.Price = price;
            Library.Books.Add(book);
        }

        var filteredBooks = Library.Books.Select(b => new { Author = b.Author, EarningsTotal = Library.Books.Where(b1 => b1.Author.Equals(b.Author)).Sum(b1 => b1.Price) }).Distinct().OrderByDescending(b => b.EarningsTotal).ThenBy(b => b.Author).ToList();

        foreach (var book in filteredBooks)
        {
            Console.WriteLine($"{book.Author} -> {book.EarningsTotal:f2}");
        }
    }
}