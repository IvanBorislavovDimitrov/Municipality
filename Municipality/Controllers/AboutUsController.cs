using Microsoft.AspNetCore.Mvc;
using Municipality.Models;

namespace Municipality.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUs()
        {
            var aboutUs = new AboutUsModel();
            return View(aboutUs);
        }
    }
}
