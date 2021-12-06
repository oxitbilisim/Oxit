using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

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