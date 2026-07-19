using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportationMongoDb.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
