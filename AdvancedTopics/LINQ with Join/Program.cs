using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_with_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { Id = 1, AuthorId = 2, Title = "First three peat" });
            books.Add(new Book() { Id = 2, AuthorId = 2, Title = "The last shot" });
            books.Add(new Book() { Id = 3, AuthorId = 1, Title = "Lord of the rings" });
            books.Add(new Book() { Id = 4, AuthorId = 3, Title = "King of football" });
            books.Add(new Book() { Id = 5, AuthorId = 4, Title = "Greatest striker ever" });

            List<Author> authors = new List<Author>();
            authors.Add(new Author() { Id = 1, Name = "Tom Brady" });
            authors.Add(new Author() { Id = 2, Name = "Michael Jordan" });
            authors.Add(new Author() { Id = 3, Name = "Edson Pele" });
            authors.Add(new Author() { Id = 4, Name = "Mike Tyson" });

            var joinList = from book in books join author in authors on book.AuthorId equals author.Id
                           select new { book, author };
            var count = 1;

            foreach (var item in joinList)
            {
                Console.WriteLine("#" + count + " Book: " + item.book.Title + " - Author: " + item.author.Name);

                count++;
            }
        }
    }
}
