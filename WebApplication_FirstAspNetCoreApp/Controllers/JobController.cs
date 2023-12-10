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
            if(model.Summary?.StartsWith("test_") == false) // nullsa summary zaten aşağıdaki kuralı uygulayacaktır. Burada null olduğu için kontrol etmedi bile. aşağıya gitti. Null değilse burada kontrolunu yapacak.
            {
                // ModelState.AddModelError("Summary","Summary alanı test_ ile başlamalıdır."); // bu bizim fırlattığımız bir hatadır. summary alanında görünür modelonly de görünmez.
                // ModelState.AddModelError(string.Empty, "Summary alanı test_ ile başlamalıdır."); // bu all alanında görünür. ve string.Empty yerine " " şeklinde boş metin de yazılabilir.
                ModelState.AddModelError(string.Empty, "Bazı alanlarda hata bulunmaktadır."); // hem genel kısımda hatayı gösterir
                ModelState.AddModelError("Summary", "Summary alanı test_ ile başlamalıdır."); // hem de özel olarak hata nerdeyse orada gösterir.
            }

            if(ModelState.IsValid) // buarada @model sayfası gönderilir ve içindeki validationlar kontrol edilir. eğer işlemde hata yoksa yani geçerliyse if bloğu çalışır.
            {
                model.Id = Guid.NewGuid();
                JobList.jobs.Add(model);
                return RedirectToAction("Index");
            }
            
            return View(model); // eğer işlemler kurallara uygun değilse sayfanın kendisine modelle birlikte dönülür ve uyarılar görünür.
           
        }

        // Job/Edit
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            Job job = JobList.jobs.FirstOrDefault(x=> x.Id == id);
            return View(job);
        }

        [HttpPost]
        public IActionResult Edit(Job model)
        {
            if (model.Summary?.StartsWith("test_") == false)
            {
                
                
                ModelState.AddModelError(string.Empty, "Bazı alanlarda hata bulunmaktadır.");
                ModelState.AddModelError("Summary", "Summary alanı test_ ile başlamalıdır.");
            }

            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
               
                return RedirectToAction("Index");
            }

            return View(model); // eğer işlemler kurallara uygun değilse sayfanın kendisine modelle birlikte dönülür ve uyarılar görünür.

        }

        // Job/Details
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            Job job = JobList.jobs.FirstOrDefault(x => x.Id == id);
            return View(job);
        }
    }
}
