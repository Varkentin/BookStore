using Microsoft.AspNetCore.Mvc;

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
            return View("Index",books);
        }
    }
}
