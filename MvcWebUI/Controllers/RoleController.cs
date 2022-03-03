using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
