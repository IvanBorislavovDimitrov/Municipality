using Microsoft.AspNetCore.Mvc;

namespace Municipality.Controllers
{
    public class UsefulController : Controller
    {
        public IActionResult Useful()
        {
            return View();
        }
    }
}
