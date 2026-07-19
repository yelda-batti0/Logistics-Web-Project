using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
