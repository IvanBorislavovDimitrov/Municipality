using Microsoft.AspNetCore.Mvc;

namespace Municipality.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Administration()
        {
            return View();
        }
    }
}
