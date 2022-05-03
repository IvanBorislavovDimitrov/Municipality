using Microsoft.AspNetCore.Mvc;

namespace Municipality.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
