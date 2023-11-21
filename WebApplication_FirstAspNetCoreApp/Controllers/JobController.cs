using Microsoft.AspNetCore.Mvc;
using WebApplication_FirstAspNetCoreApp.Models;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class JobController : Controller
    {

       // public static List<Job> jobs = new List<Job>(); --> newlenmesini istemiyoruz static tutacağımız için
       // buna JobList diye ayrı bir class açıyoruz model'de.

        // Job/Index ---> Sayfa adı

        [HttpGet] // burada aslında böyle bir attribute çalışır. Bu sayfalardaki veriler getirmek için kullanılır
        public IActionResult Index()
        {
            return View(JobList.jobs);
        }


        //[HttpPost] // burada da sayfaya girilen verileri alırız.
        //public IActionResult Index() 
        //{
        //    return View();
        //}

        // Job/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Job model)
        {
            JobList.jobs.Add(model);
            return RedirectToAction("Index");
        }
    }
}
