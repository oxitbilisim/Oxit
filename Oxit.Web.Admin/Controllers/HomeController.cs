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
    public class HomeController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;


        public HomeController(IConfiguration configuration, appDbContext appDbContext)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
            this.appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            var aktifFirmaSayi = appDbContext.HesapPlani.Where(h => h.Aktif).Count();
            var toplamBorc = appDbContext.Fis.Where(f => f.HesapPlani.Aktif && f.FisTip == FisTip.KiraFaturasi).Sum(b => b.Borc + b.GecikmeTutari);
            var toplamOdeme = appDbContext.Fis.Where(f => f.HesapPlani.Aktif && f.FisTip == FisTip.KiraOdemesi).Sum(b => b.Alacak);

            Dictionary<string, object> model = new Dictionary<string, object>();
            model["aktifFirmaSayi"] = aktifFirmaSayi;
            model["toplamBorc"] = toplamBorc;
            model["toplamOdeme"] = toplamOdeme;
            model["kalanAlacak"] = toplamBorc-toplamOdeme;
            return View(model);
        }
    }
}
