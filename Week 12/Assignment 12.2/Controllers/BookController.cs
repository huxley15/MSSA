using Microsoft.AspNetCore.Mvc;
using Assignment12._2._2.Models;

namespace Assignment12._2._2.Controllers
{
    //step 6 create bookcontroller
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            //dependency injection
            _bookRepository = bookRepository;
        }

        //step 9 - method pointed to by Details method in Book/Details
        public IActionResult Details(int? id)
        {
            var model = _bookRepository.GetBookById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        //step 7 - modify index method for Book/index
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Books=_bookRepository.InitializeData();
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
