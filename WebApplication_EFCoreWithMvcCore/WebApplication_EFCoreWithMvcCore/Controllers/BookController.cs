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

        [HttpGet]
        public IActionResult Details(int id)
        {
           Book book= _db.Books.FirstOrDefault(b=> b.Id == id);

            return View(book);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
          Book book=_db.Books.FirstOrDefault(b=> b.Id == id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            if (ModelState.IsValid)
            {
                Book bookdb = _db.Books.FirstOrDefault(b=> b.Id==id);
                bookdb.Title =book.Title;
                bookdb.Author =book.Author;
                bookdb.Summary =book.Summary;
                bookdb.PageCount = book.PageCount;
                bookdb.Published = book.Published;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Book book = _db.Books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        [ActionName("Delete")] // metodun ismi ne kadar farklı olsa da bu aslında bir delete actionıdır diyoruz.
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
          
                Book bookdb = _db.Books.FirstOrDefault(b => b.Id == id);
                _db.Books.Remove(bookdb);
                _db.SaveChanges();
                
                return RedirectToAction("Index");
            
        }


    }
}
