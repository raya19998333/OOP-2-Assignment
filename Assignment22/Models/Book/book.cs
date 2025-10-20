using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Book
{
    internal class book
    {
        // Properties of the Book class
        private string title;
        private string author;
        private int publicationYear;
        private string isbn;

        // Constructor to initialize the Book object
        public book(string title, string author, int publicationYear, string isbn)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.isbn = isbn;
        }
        // Method to print book information
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Publication Year: {publicationYear}");
            Console.WriteLine($"ISBN: {isbn}");
        }
        // Method to check if the book is older than a given year
        public void isOlderThan(int year)
        {
            // Compare publication year with the given year
            if (publicationYear < year)
            {
                Console.WriteLine($"{title} is older than {year}.");
            }
            else
            {
                Console.WriteLine($"{title} is not older than {year}.");
            }
        }


    }
}
