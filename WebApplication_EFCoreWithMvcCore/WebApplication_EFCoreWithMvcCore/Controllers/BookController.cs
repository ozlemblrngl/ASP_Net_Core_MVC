using Microsoft.AspNetCore.Mvc;
using WebApplication_EFCoreWithMvcCore.Models.Entities;

namespace WebApplication_EFCoreWithMvcCore.Controllers
{
    public class BookController : Controller
    {
        private DatabaseContext _db = new DatabaseContext();
        [HttpGet]
        public IActionResult Index()
        {
            
            List<Book> books= _db.Books.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(ModelState.IsValid) 
            {
                _db.Books.Add(book);    
                _db.SaveChanges();
             return RedirectToAction("Index");
            }

            return View(book);
        }


    }
}
