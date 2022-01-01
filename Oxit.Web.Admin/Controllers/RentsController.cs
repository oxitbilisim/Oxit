using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;
using Oxit.Domain.Models;

namespace Oxit.Web.Admin.Controllers
{
    public class RentsController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;

        public RentsController(
            IConfiguration configuration,
            appDbContext appDbContext)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
            this.appDbContext = appDbContext;
        }

        public IActionResult Index(int? page)
        {
            return View();
        }



    }
}