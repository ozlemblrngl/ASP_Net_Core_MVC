using Microsoft.AspNetCore.Mvc;

namespace WebApplication_FirstAspNetCoreApp.Controllers
{
    public class AccountController : Controller
    {
        // ...Account/Login şeklinde görünecektir. sayfanın adresidir. üç nokta ile gösterilen ön kısmında ise doman yer alır.
        public IActionResult Login() // o sayfaya ne isim vereceksek onu yazmakta fayd var Login() e çevirdik o nedenle
        {
            return View();
        }
        // ...Account/Register şeklinde görünecektir. sayfanın adresidir. üç nokta ile gösterilen ön kısmında ise doman yer alır.
        // Account controllerınde register adlı metodu çağıran action dır.
        public IActionResult Register() // o sayfaya ne isim vereceksek onu yazmakta fayd var Register() e çevirdik o nedenle
        {
            return View();
        }
    }

}
