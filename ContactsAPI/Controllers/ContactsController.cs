using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
