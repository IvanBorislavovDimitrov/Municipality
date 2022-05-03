using Microsoft.AspNetCore.Mvc;

namespace Municipality.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
