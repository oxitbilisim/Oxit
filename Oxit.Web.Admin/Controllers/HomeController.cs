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
        private readonly TeknoparkContext _db;
        private readonly IConfiguration _configuration;
        private readonly appDbContext _appDbContext;


        public HomeController(
            IConfiguration configuration,
            appDbContext appDbContext,
            TeknoparkContext db
            )
        {
            _configuration = configuration;
            _db = db;
            _appDbContext = appDbContext;

        }
        public IActionResult Index()
        {
            var aktifFirmaSayi = _appDbContext.HesapPlani.Where(h => h.Aktif).Count();
            var toplamBorc = _appDbContext.Fis.Where(f => f.HesapPlani.Aktif).Sum(b => b.Borc );
            var toplamOdeme = _appDbContext.Fis.Where(f => f.HesapPlani.Aktif).Sum(b => b.Alacak);
            
            List<ChartLine> chartData = _appDbContext.Fis.AsEnumerable().GroupBy(f => String.Format("{0:MM yyyy}", f.Tarih))
                .Select(cl => new ChartLine
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
            
            List<HesapPlaniDto> gecikmesiOlanFirmalar = _appDbContext.Fis.Where(f => f.GecikmeGunu > 0 && !f.Odendi)
                .GroupBy(f => f.HesapPlaniId).Select(cl => new HesapPlaniDto
            {
                Ad = cl.First().HesapPlani.Ad,
                Kod = cl.First().HesapPlani.Kod,
                GecikmeTutari = Math.Round(cl.Sum(c => c.GecikmeTutari).Value,2)
                
            }).ToList();

            
            
            Dictionary<string, object> model = new Dictionary<string, object>();
            model["aktifFirmaSayi"] = aktifFirmaSayi;
            model["toplamBorc"] = toplamBorc;
            model["toplamOdeme"] = toplamOdeme;
            model["kalanAlacak"] = toplamBorc - toplamOdeme;
            model["labels"] = labels;
            model["borc"] = borc;
            model["alacak"] = alacak;
            model["gecikme"] = gecikme;
            model["gecikmesiOlanFirmalar"] = gecikmesiOlanFirmalar;
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
