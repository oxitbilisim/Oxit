using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;

namespace Oxit.Web.Admin.Controllers
{
    [Route("api/[controller]")]
    public class GecikmeHesaplaController : Controller
    {
        private readonly appDbContext appDbContext;
        private readonly IConfiguration configuration;

        public GecikmeHesaplaController(IConfiguration configuration, appDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.configuration = configuration;
            
        }

        [HttpGet("GecikmeleriHesapla")]
        public EmptyResult GecikmeleriHesapla(string hesapKodu)
        {
            var gecikmeOrani = Convert.ToDecimal(configuration.GetSection("gecikmeOrani").Value);
            var gecikmeGunu = Convert.ToInt32(configuration.GetSection("gecikmeGunu").Value);

            var fisAlacakList = appDbContext.Fis
                                           .Include(y => y.HesapPlani)
                                           .Where(y => y.HesapPlani.Kod == hesapKodu && 
                                                       y.Alacak >= 0 &&
                                                       (int)y.FisTip == (int)Domain.Models.FisTip.KiraOdemesi
                                                )
                                          .OrderBy(c => c.Tarih).ThenBy(n => n.Id)
                                          .ToList();

            foreach (var itemAlacak in fisAlacakList)
            {
                var alacakTutari = itemAlacak.Alacak;

                while (alacakTutari > 0)
                {
                    var fisBorc = appDbContext.Fis
                                          .Where(y => y.HesapPlaniId == itemAlacak.HesapPlaniId && y.Borc > 0 && !y.Odendi &&
                                                      (int)y.FisTip == (int)Domain.Models.FisTip.KiraFaturasi
                                                      )
                                          .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                                          .FirstOrDefault();

                    var borcTutari = fisBorc.KalanTutar > 0 ? (double)fisBorc.KalanTutar : (double)fisBorc.Borc;
                    var gecikmeGun = (DateTime)itemAlacak.Tarih > (DateTime)fisBorc.Tarih ? ((DateTime)itemAlacak.Tarih - (DateTime)fisBorc.Tarih).TotalDays : 0;

                    if (gecikmeGun >= gecikmeGunu)
                    {
                        fisBorc.GeciktirilenAnaFaizTutar = (double)fisBorc.Borc;
                        fisBorc.GeciktirilenTutar = fisBorc.KalanTutar;
                        fisBorc.GecikmeGunu = (int)gecikmeGun;
                        fisBorc.GecikmeTutari = Math.Round(((borcTutari * (double)gecikmeOrani) / 30) * (int)gecikmeGun, 2);
                        fisBorc.SonHesaplananGecikmeTarihi = itemAlacak.Tarih;
                    }

                    if (borcTutari > alacakTutari)
                    {
                        fisBorc.KalanTutar = Math.Round((double)(borcTutari - alacakTutari),2);
                        alacakTutari = 0;
                        fisBorc.Odendi = false;
                        //itemAlacak.KalanTutar = fisBorc.Id;
                    }
                    else
                    {
                        fisBorc.KalanTutar = 0;
                        fisBorc.Odendi = true;
                        alacakTutari = alacakTutari - borcTutari;
                        fisBorc.ZamanindaOdenenTutar = Math.Round((double)fisBorc.Borc, 2);
                        fisBorc.ZamanindaOdemeTarihi = itemAlacak.Tarih;
                       
                    }
                    appDbContext.SaveChanges();
                }
            }

            return new EmptyResult();
        }

        [HttpGet("GecikmeleriSifirla")]
        public EmptyResult GecikmeleriSifirla(string hesapKodu)
        {
            var fisList = appDbContext.Fis
                                           .Include(y => y.HesapPlani)
                                           .Where(y => y.HesapPlani.Kod == hesapKodu )
                                           .OrderBy(c => c.Tarih).ThenBy(n => n.Id)
                                           .ToList();

            foreach (var item in fisList)
            {
                item.GecikmeGunu = 0;
                item.GecikmeTutari = 0;
                item.GeciktirilenAnaFaizTutar = 0;
                item.Odendi = false;
                item.KalanTutar = 0;
                item.ZamanindaOdenenTutar = 0;
                item.ZamanindaOdemeTarihi = null;
                item.SonHesaplananGecikmeTarihi = null;
                item.GeciktirilenTutar = 0;
                appDbContext.SaveChanges();
            }

            return new EmptyResult();
        }
    }
}
