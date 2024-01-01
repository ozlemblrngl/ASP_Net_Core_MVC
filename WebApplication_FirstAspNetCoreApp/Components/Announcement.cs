using Microsoft.AspNetCore.Mvc;

namespace WebApplication_FirstAspNetCoreApp.Components
{
    [ViewComponent]
    public class Announcement : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<string> items = new List<string>
            {
                "lorem", "ipsum", "pactum","sanction", "lorempt"
            };

            return View(items);
        }
    }
}
