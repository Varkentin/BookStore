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
            new Book(1,"ISBN 0201038013","Author1","test1","1This volume begins with basic concepts and techniques",8.19m),
            new Book(2,"ISBN 0201485672","Author2","test2","2This volume begins with basic concepts and techniques",10.2m),
            new Book(3,"ISBN 0131101633","Author3","test3","3This volume begins with basic concepts and techniques",15.8m),

        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }



        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }

       
    }
}
