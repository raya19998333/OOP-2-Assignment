using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Book
{
    internal class book
    {
        private string title;
        private string author;
        private int publicationYear;
        private string isbn;

        public book(string title, string author, int publicationYear, string isbn)
        {
            this.title = title;
            this.author = author;
            this.publicationYear = publicationYear;
            this.isbn = isbn;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Publication Year: {publicationYear}");
            Console.WriteLine($"ISBN: {isbn}");
        }
        public void isOlderThan(int year)
        {
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
