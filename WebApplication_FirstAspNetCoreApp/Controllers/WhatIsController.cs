using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplication_FirstAspNetCoreApp.Models;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class WhatIsController : Controller
    {
        public IActionResult RazorSyntax()
        {
            return View();
        }

        public IActionResult HtmlHelpers()
        {
            Student student = new Student()
            {
                FirstName = "Mustafa"
            };
            return View(student);
        }

        public IActionResult ViewBagViewDataTempData()
        {
            ViewBag.NameSurname = "Özlem Belörenoğlu";
            ViewBag.PostalCode = 06930;

            ViewData["FullName"] = "john doe";
            ViewData["IsActive"] = true;

            TempData["TempNumber"] = 123;

            //KeyValuePair<string, int> deger = new KeyValuePair<string, int>("bir", 1);
            //KeyValuePair<string, int> deger2 = new KeyValuePair<string, int>("iki", 2);

            // aşağıda yukarıdaki gibi değil de kendi class ımızı da yaparak yapabiliriz

            List<DropDownDataItem> items = new List<DropDownDataItem>
            {
                new DropDownDataItem()
                {
                    Id = 34,
                    Value = "İstanbul"
                },

                 new DropDownDataItem()
                {
                    Id = 06,
                    Value = "Ankara"
                },
                  
                 new DropDownDataItem()
                {
                    Id = 35,
                    Value = "İzmir"
                },

                  new DropDownDataItem()
                {
                    Id = 55,
                    Value = "Samsun"
                }
            };

            ViewData["Cities"] = items; // ViewBag de kullanılabilir.
            return View();
        }

        public IActionResult ViewBagViewDataTempData2()
        {
           
            return View();
        }


    }

    public class DropDownDataItem
    {
        public int Id { get; set; } 
        public string Value { get; set; }
   
    }
}
