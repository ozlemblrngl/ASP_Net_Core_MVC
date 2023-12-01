using Microsoft.AspNetCore.Mvc;

namespace WebApplication_MvcCoreCodes.Controllers
{
    public class ProductController : Controller
    {
        [Route("product/edit/{productId:int}")]
       // [Route("product/productId:bool:datetime:float:double:decimal:guid:long")] // kullandığımız parametre ne ise ona uygun olanı kullanabiliriz.
        public IActionResult Edit(int productId)
        {
            return Content( $"Product ID = {productId} ");
        }

        [Route("product/detail/{productId:min(300)}/{prefix}")]  // length, range constraint denir bunlara
        [Route("product/detail/{productId:range(1,200)}/{prefix:minLength(3)}")]
        [Route("product/detail/{productId:int:range(250,299)}/{prefix:minLength(3):maxLength(5)}")]
        public IActionResult Details(int productId, string prefix)
        {
            return Content($"Product ID = {productId} - Prefix = {prefix} ");
        }

        // Regex --> regular expression constraint
        [Route(@"product/save/{productId:int}/{code:regex(^[[5-8]]{{3}}-[[2-5]]{{2}}$)}")]  // --> ^ ve $ arasına yazılır kural
        // 5 ile 8 arasında 3 sayı olacak ve 2 ile 5 arasında 2 sayı olacak. örn--> product/save/123/678-35 --> dikkat arada - olacak / değil.
        // diğer parantezlerle karışmaması için regex kurallarını çift parantezlere alıyoruz iç içe.
        // @ --> regex te bazı özel karakterler kullandığımızdan @ kullanıyoruz.
        // regex'le istediğimiz karmaşıklıkta sınırlandırma koyabiliriz.
        public IActionResult Save(int productId, string code)
        {
            return Content($"Product ID = {productId} - Code = {code} ");
        }
    }
}
