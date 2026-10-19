using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
