using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;

namespace Oxit.Web.Admin.Controllers
{
    public class SeperationController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;

        public SeperationController(IConfiguration configuration)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
           
        }
        public IActionResult Index()
        {
            //var ss = db.Yevmiyes.ToList();
            return View();
        }
    }
}