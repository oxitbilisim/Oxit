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
            GecikmeHesapla("120 A004");

            var firmalar = appDbContext.HesapPlani.ToList();
            return View(firmalar);
        }

        public void GecikmeHesapla(string hesKod)
        {
            var zamanindaOdenen = 0.0;
            var fis = appDbContext.Fis
                                  .Include(y => y.HesapPlani)
                                  .Where(y => y.HesapPlani.Kod == hesKod && y.Borc > 0)
                                  .OrderBy(y=> y.Tarih)
                                  .ToList();

            foreach (var item in fis)
            {
                var sonAlacakTarihi = appDbContext.Fis
                                                  .Where(c => item.HesapPlaniId == c.HesapPlaniId &&
                                                              c.Tarih >= item.Tarih &&
                                                              c.Alacak >= 0
                                                        )
                                                  .OrderBy(c => c.Tarih)
                                                  .FirstOrDefault()?.Tarih;

                if (sonAlacakTarihi != null)
                {
                  
                    var gecikmeGun = 
                        ((DateTime)sonAlacakTarihi - (DateTime)item.Tarih).TotalDays;

                    if (gecikmeGun > 45)
                    {
                        item.GecikmeTutari = item.Borc * (0.152 / 30) * gecikmeGun;
                        item.SonHesaplananGecikmeTarihi = sonAlacakTarihi;

                        appDbContext.SaveChanges();
                    }
                    else
                    {
                        zamanindaOdenen =+ (double)item.Borc;
                        
                        //item.GecikmeTutari = item.Borc * (0.152 / 30) * gecikmeGun;
                        //item.SonHesaplananGecikmeTarihi = sonAlacakTarihi;

                        //appDbContext.SaveChanges();
                    }

                }
                Console.WriteLine(item.Tarih + "|"+ item.Borc);
            }
           // return 1.24;
        }
    }
}