using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store.Memory
{
   public class BookRepository : IBookRepository

    {
        private readonly Book[] books = new[]
        {
            new Book(1,"ISBN1","Author1","test1"),
            new Book(2,"ISBN2","Author2","test2"),
            new Book(3,"ISBN3","Author3","test3"),

        };

        public Book[] GetAllByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAllByTitle(string title)
        {
            return books.Where(book => book.Title.Contains(title)).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
