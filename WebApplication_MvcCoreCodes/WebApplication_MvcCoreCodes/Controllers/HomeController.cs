using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using WebApplication_MvcCoreCodes.Models;

namespace WebApplication_MvcCoreCodes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LocalFunctions()
        {
            return View();
        }

        public IActionResult TemplatedDelegates()
        {
            return View();
        }

        public IActionResult ClientSideModelValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClientSideModelValidation(User model)
        {
            if (ModelState.IsValid)
            {
                // kaydet ve yönlendirme işlemi yaparız
            }

            return View(model);
        }

        public IActionResult ContentResult()
        {
            return Content("Hello World");
        }

        public IActionResult RedirectResult(int versiyon = 1)
        {
            switch (versiyon)
            {
                case 2:
                    return RedirectPermanent("/Home/ContentResult");
                case 1:
                default:
                    return Redirect("/Home/ContentResult");
            };
        }

        public IActionResult FileResult() 
        {
            return File("~/files/sample.pdf","application/pdf");
        }

        public IActionResult StatusCodeResult(int versiyon =1)
        {
            switch(versiyon)
            {
                case 2:
                   // return new StatusCodeResult((int)HttpStatusCode.NotFound); --> böyle de yazılır
                    return NotFound();
                default:
                    return new StatusCodeResult((int)HttpStatusCode.Created);
                   // return Created(); --> böyle de yazılır
            }
            
        }

        public IActionResult JsonResult()
        {
            //User user = new User()
            //{
            //    FirstName = NameData.GetFirstName(),
            //    LastName = NameData.GetSurname(),
            //    Email = NetworkData.GetEmail(),
            //};
            // return Json(user);
             return Json(new { FullName = "özlem Belörenoğlu", Mail = "ozlem@ozlem.com" });
        }

        public IActionResult PartialViewResult(int versiyon =1)
        {
            if(versiyon == 1)
            {
                return PartialView("_CardPartial", new User { FirstName ="Mustafa", LastName ="Belörenoğlu", Email="mustafa@ozlem.com" } );
            }
            else
            {
                return PartialView("_CardPartial");
            }
        }

        public IActionResult PartialViewPage()
        {
            return View();
        }
    }
}