using Microsoft.AspNetCore.Mvc;
using WebApplication_FirstAspNetCoreApp.Models;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{

    // /Student/Details (ilki controller ikncisi action
    public class StudentController : Controller //controller
    {
        public IActionResult Details() //action
        {

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Özlem",
                LastName = "Belörenoğlu",
                Age = 31,
                IsRegistrationNew = true,
                Password = "1234"
            };
            return View(student);
        }
    }
}
