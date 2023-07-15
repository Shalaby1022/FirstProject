using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
