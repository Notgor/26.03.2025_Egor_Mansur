using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book otherBook)
            {
                return ISBN == otherBook.ISBN;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }
    }

    class Task4
    {
        public static void Execute()
        {
            HashSet<Book> books = new HashSet<Book>
            {
                new Book("978-3-16-148410-0", "Book One", "Author A"),
                new Book("978-1-23-456789-7", "Book Two", "Author B"),
                new Book("978-3-16-148410-0", "Duplicate Book", "Author C")
            };

            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}

