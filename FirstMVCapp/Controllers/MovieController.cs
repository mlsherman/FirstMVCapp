using Microsoft.AspNetCore.Mvc;

namespace FirstMVCapp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
