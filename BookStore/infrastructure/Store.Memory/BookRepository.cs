using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Memory
{
    class BookRepository : IBookRepository

    {
        private readonly Book[] books = new[]
        {
            new Book(1,"test1"),
            new Book(2,"test2"),
            new Book(3,"test3"),

        };

  

        public Book[] GetAllByTitle(string title)
        {
            return books.Where(book => book.Title.Contains(title)).ToArray();
        }
    }
}
