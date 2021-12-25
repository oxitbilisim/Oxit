﻿using Microsoft.AspNetCore.Mvc;
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
            GecikmeHesapla("120 A005");

            var firmalar = appDbContext.HesapPlani.ToList();
            return View(firmalar);
        }

        public void GecikmeHesapla(string hesKod)
        {
            var kalanAlacakTutar = 0.0;
            var odenecekTutar = 0.0;
            var fis = appDbContext.Fis
                                  .Include(y => y.HesapPlani)
                                  .Where(y => y.HesapPlani.Kod == hesKod && y.Borc > 0)
                                  .OrderBy(y => y.Tarih)
                                  .ToList();

            foreach (var item in fis)
            {
                odenecekTutar = (double)item.Borc;
                var alacakList = appDbContext.Fis
                                                  .Where(c => item.HesapPlaniId == c.HesapPlaniId &&
                                                              c.Tarih >= item.Tarih &&
                                                              c.Alacak >= 0 &&
                                                              c.Alacak != c.KalanTutar
                                                        )
                                                  .OrderBy(c => c.Tarih)
                                                  .ToList();


               
                foreach (var itemAlacak in alacakList)
                {
                    kalanAlacakTutar = (double)itemAlacak.KalanTutar > 0 ? (double)itemAlacak.KalanTutar : (double)itemAlacak.Alacak;
                    var gecikmeGun = (DateTime)itemAlacak.Tarih > (DateTime)item.Tarih  ? 
                                           ((DateTime)itemAlacak.Tarih - (DateTime)item.Tarih).TotalDays : 0;

                    if (gecikmeGun > 45)
                    {
                        item.GeciktirilenAnaFaizTutar = odenecekTutar;
                        item.GecikmeTutari = ((odenecekTutar * 0.0152) / 30 ) * gecikmeGun;
                        item.SonHesaplananGecikmeTarihi = itemAlacak.Tarih;
             

                        if (odenecekTutar >= kalanAlacakTutar)
                        {
                            odenecekTutar = odenecekTutar - kalanAlacakTutar;
                            item.GeciktirilenTutar = odenecekTutar;

                            itemAlacak.KalanTutar = (double)itemAlacak.Alacak;
                        }
                        else
                        {
                            item.KalanTutar = 0;
                            item.ZamanindaOdenenTutar = (double)item.Borc;
                            item.ZamanindaOdemeTarihi = itemAlacak.Tarih;

                            itemAlacak.KalanTutar = kalanAlacakTutar - odenecekTutar;
                        }
                        appDbContext.SaveChanges();
                    }
                    else
                    {
                        if (odenecekTutar >= kalanAlacakTutar)
                        {
                            odenecekTutar = odenecekTutar - kalanAlacakTutar;

                            itemAlacak.KalanTutar = (double)itemAlacak.Alacak;
                        }
                        else
                        {
                            item.KalanTutar = 0;
                            item.ZamanindaOdenenTutar = (double)item.Borc;
                            item.ZamanindaOdemeTarihi = itemAlacak.Tarih;

                            itemAlacak.KalanTutar = kalanAlacakTutar - odenecekTutar;
                        }
                        appDbContext.SaveChanges();

                         
                    }
                    if (item.ZamanindaOdenenTutar > 0)
                        break;

                }
                Console.WriteLine(item.Tarih + "|" + item.Borc);
            }
            // return 1.24;
        }
    }
}
