using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MvcCoreCodes.Controllers
{
   // [Route("/Categories")] // convention based routing
    public class CategoryController : Controller
    {
        // [HttpGet] ---> convention based routing

        [Route("/categories")] // --> attribute base routing
        public IActionResult List()
        {
            return Content("Category List");
        }

        // iki metot da get'tir eğer birine ayrıca belirtmeden kullanırsak hata alırız.
        // ya da diğerine id li parametre veririz.
        // [Route("{id}")]----> convention based routing

        [Route ("/categories/{id}")] // --> attribute base routing
        public IActionResult Details(int id)
        {
            return Content("Category List");
        }
    }
}
