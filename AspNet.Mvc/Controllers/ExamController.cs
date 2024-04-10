using AspNet.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.Mvc.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            BooksDb booksDB = new BooksDb();

            List<Book> books = booksDB.getBooks();

            ViewBag.Title = "Popis knjiga";

            return View("~/Views/Exam.cshtml", books);
        }
    }
}
