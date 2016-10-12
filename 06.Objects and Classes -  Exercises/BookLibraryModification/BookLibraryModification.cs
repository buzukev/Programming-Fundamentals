using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string isbnNumber { get; set; }
    public double Price { get; set; }
}
public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}


public class BookLibraryModification
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
            DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

        string inputDate = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> filteredBook = new Dictionary<string, DateTime>();

        for (int i = 0; i < Library.Books.Count; i++)
        {
            if (!filteredBook.ContainsKey(Library.Books[i].Title))
            {
                filteredBook.Add(Library.Books[i].Title, Library.Books[i].ReleaseDate);
            }

            else
            {
                filteredBook[Library.Books[i].Title] = Library.Books[i].ReleaseDate;
            }
        }
        foreach (var book in filteredBook.Where(s => s.Value > startDate).OrderBy(x => x.Value).ThenBy(y => y.Key))
        {
            Console.WriteLine($"{book.Key} -> {book.Value.ToString("dd.MM.yyyy")}");
        }
    }
}