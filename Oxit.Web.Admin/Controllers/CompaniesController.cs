using Microsoft.AspNetCore.Mvc;

namespace Oxit.Web.Admin.Controllers
{
    public class CompaniesController : Controller
    {
        public CompaniesController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}