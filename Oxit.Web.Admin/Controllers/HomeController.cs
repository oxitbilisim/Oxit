using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;

namespace Oxit.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly Teknopark2021Context db;
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new Teknopark2021Context(cn);
           
        }
        public IActionResult Index()
        {

            var ss = db.Yevmiyes.ToList();
            return View();
        }
    }
}