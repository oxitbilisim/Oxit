using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;
using Oxit.Domain.Models;
using Microsoft.AspNetCore.Diagnostics;

namespace Oxit.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;


        public HomeController(
            IConfiguration configuration,
            appDbContext appDbContext,
            TeknoparkContext db
            )
        {
            this.configuration = configuration;
            this.db = db;
            this.appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            var aktifFirmaSayi = appDbContext.HesapPlani.Where(h => h.Aktif).Count();
            var toplamBorc = appDbContext.Fis.Where(f => f.HesapPlani.Aktif && f.FisTip == FisTip.KiraFaturasi).Sum(b => b.Borc + b.GecikmeTutari);
            var toplamOdeme = appDbContext.Fis.Where(f => f.HesapPlani.Aktif && f.FisTip == FisTip.KiraOdemesi).Sum(b => b.Alacak);
            List<ChartLine> chartData = appDbContext.Fis.AsEnumerable().GroupBy(f => String.Format("{0:MM yyyy}", f.Tarih)).Select(cl => new ChartLine
            {
                Date = String.Format("{0:MM-yyyy}", cl.First().Tarih),
                Alacak = cl.Sum(c => c.Alacak),
                Borc = cl.Sum(c => c.Borc),
                Gecikme = cl.Sum(c => c.GecikmeTutari)
            }).OrderBy(f => f.Date).Take(12).ToList();
            List<string> labels = new List<string>();
            List<Int32> borc = new List<Int32>();
            List<Int32> alacak = new List<Int32>();
            List<Int32> gecikme = new List<Int32>();
            foreach (var item in chartData)
            {
                labels.Add(item.Date);
                borc.Add(Convert.ToInt32((item.Borc.Value)));
                alacak.Add(Convert.ToInt32((item.Alacak.Value)));
                gecikme.Add(Convert.ToInt32((item.Gecikme.Value)));
            }

            Dictionary<string, object> model = new Dictionary<string, object>();
            model["aktifFirmaSayi"] = aktifFirmaSayi;
            model["toplamBorc"] = toplamBorc;
            model["toplamOdeme"] = toplamOdeme;
            model["kalanAlacak"] = toplamBorc - toplamOdeme;
            model["labels"] = labels;
            model["borc"] = borc;
            model["alacak"] = alacak;
            model["gecikme"] = gecikme;
            return View(model);
        }


        [HttpGet,Route("/Home/Error")]
        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =
           HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return View(exceptionHandlerPathFeature);
        }
    }
}

