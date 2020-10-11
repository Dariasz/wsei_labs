using Microsoft.AspNetCore.Mvc;
using WseiLabs.Models;

namespace WseiLabs.Controllers
{
    public class CompanyController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible,
            };
            return View("CompanyAdded", viewModel);
        }
    }
}