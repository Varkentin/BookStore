using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Memory;

namespace Store.Web.Controllers
{
   
    public class SearhController : Controller
    {
        private readonly BookService bookService;

        public SearhController(BookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);
            return View(books);
        }
    }
}
