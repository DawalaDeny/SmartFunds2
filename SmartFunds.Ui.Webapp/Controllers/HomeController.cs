using Microsoft.AspNetCore.Mvc;
using SmartFunds.Ui.Webapp.Data;

namespace SmartFunds.Ui.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly SmartFundsDatabase _database;

        public HomeController(SmartFundsDatabase database)
        {
            _database = database;
        }
        public IActionResult Index()
        { 
            var organizations = _database.Organizations;
            return View(organizations);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}