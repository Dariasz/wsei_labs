using Microsoft.AspNetCore.Mvc;

namespace WseiLabs.Controllers
{
    public class ExchangesController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}