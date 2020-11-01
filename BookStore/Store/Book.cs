using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Book
    {
 
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
