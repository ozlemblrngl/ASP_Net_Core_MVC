using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MvcCoreCodes.Controllers
{
    public class BlogController : Controller
    {
        [Route("Blog/post/create")] // [Route("Blog/create")] ne yazardak ona gider
        public IActionResult Create()
        {
            return Content("Post Created");
        }

        [Route("blog/post/edit/{blogId}/{slug}")]
        public IActionResult Edit(int blogId, string slug)  // slug --> arama motorlarında ceo ya göre ingilizce karakterli düzenlenmesi başlığın 
                                                            // örn üzümün faydaları --> uzumun faydalari
        {
            return Content($"Post Edit#: {blogId} - slug : {slug} ");
        }

        // * --> catch all parameters  
        [Route("blog/post/edit2/{blogId}/{*slug}")]   // ---> blog/post/edit2/123/the-cat/book/price --> {slug: the-cat/book/price}
        public IActionResult Edit2(int blogId, string slug)
        {
            return Content($"Post Edit#: {blogId} - slug : {slug} ");
        }

        //optional parameters --> olmasa da olur parametresi. ? konularak belirtilir.
        [Route("blog/post/edit3/{blogId}/{slug?}")]
        public IActionResult Edit3(int blogId, string slug)
        {
            return Content($"Post Edit3#: {blogId} - slug : {slug} ");
        }

        // optional parameters with default value --> eğer slug için bir değer geliyorsa o yazılı, slug için değer gelmiyorsa default yazdırılır.
        [Route("blog/post/edit4/{blogId}/{slug?}")]
        public IActionResult Edit4(int blogId, string slug = "Sample")
        {
            return Content($"Post Edit4#: {blogId} - slug : {slug} ");
        }

        // reserved routing names --> önceden rezerve olmuş, kullanılmış olan kelimeler, bunları kullanmamalıyız.
        /*
        Controller
        Action
        Handler
        Page
        Area
        Bu ifadeleri kullanmıyoruz çünkü bunlar zaten kullanılıyor.
         */
    }
}
