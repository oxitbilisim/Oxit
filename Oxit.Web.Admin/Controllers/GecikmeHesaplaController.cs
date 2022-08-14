using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.Domain;

namespace Oxit.Web.Admin.Controllers
{
    [Route("api/[controller]")]
    public class GecikmeHesaplaController : Controller
    {
        private readonly appDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        private readonly HesapPlaniService _hesapPlaniService;

        public GecikmeHesaplaController(IConfiguration configuration, appDbContext appDbContext, HesapPlaniService hesapPlaniService)
        {
            _appDbContext = appDbContext;
            _configuration = configuration;
            _hesapPlaniService = hesapPlaniService;
        }

        [HttpGet("GecikmeleriHesaplaBakiye")]
        public EmptyResult GecikmeleriHesaplaBakiye(string hesapKodu)
        {
            _hesapPlaniService.GecikmeleriHesaplaBakiye(hesapKodu);

            return new EmptyResult();
        }
        
        [HttpGet("GecikmeleriHesapla")]
        public EmptyResult GecikmeleriHesapla(string hesapKodu)
        {
            _hesapPlaniService.GecikmeleriHesapla(hesapKodu);

            return new EmptyResult();
        }

        [HttpGet("AlacaksizGecikmeHesapla")]
        public EmptyResult AlacaksizGecikmeHesapla(string hesapKodu)
        {
            _hesapPlaniService.AlacaksizGecikmeHesapla(hesapKodu);
            return new EmptyResult();
        }


        [HttpGet("GecikmeleriSifirla")]
        public EmptyResult GecikmeleriSifirla(string hesapKodu)
        {
            var fisList = _appDbContext.Fis
                                           .Include(y => y.HesapPlani)
                                           .Where(y => y.HesapPlani.Kod == hesapKodu)
                                           .OrderBy(c => c.Tarih).ThenBy(n => n.Id)
                                           .ToList();

            foreach (var item in fisList)
            {
                item.GecikmeGunu = 0;
                item.GecikmeTutari = 0;
                item.GeciktirilenAnaFaizTutar = 0;
                item.Odendi = false;
                item.KalanTutar = 0;
                
                item.OdenenBorcTutar = 0;
                item.KalanAlacakTutar = 0;
                item.KalanBorcTutar = 0;
                item.ZamanindaOdenenTutar = 0;
                item.ZamanindaOdemeTarihi = null;
                item.SonHesaplananGecikmeTarihi = null;
                item.GeciktirilenTutar = 0;
                _appDbContext.SaveChanges();
            }

            return new EmptyResult();
        }
    }
}
