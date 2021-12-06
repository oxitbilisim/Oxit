using Microsoft.AspNetCore.Mvc;
using Oxit.Web.Admin.Models;
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