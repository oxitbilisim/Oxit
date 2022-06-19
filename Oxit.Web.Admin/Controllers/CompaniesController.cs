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
    public class CompaniesController : Controller
    {
        private readonly TeknoparkContext _db;
        private readonly IConfiguration _configuration;
        private readonly appDbContext _appDbContext;

        public CompaniesController(
            IConfiguration configuration,
            appDbContext appDbContext,
            TeknoparkContext db
            )
        {
            _configuration = configuration;
            _db = db;
            _appDbContext = appDbContext;
        }
        public IActionResult Index(string name, string kod)
        {
            List<HesapPlaniDto> firmalar = _appDbContext.HesapPlani
                .Select(x => new HesapPlaniDto
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Kod = x.Kod,
                    Borc =    Convert.ToDouble(_appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id && y.HesapPlani.Aktif).Sum(y => y.Borc)),
                    Alacak =    Convert.ToDouble(_appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id && y.HesapPlani.Aktif).Sum(y => y.Alacak)),
                    Bakiye = Convert.ToDouble(_appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id && y.HesapPlani.Aktif).Sum(y => y.Borc))  - Convert.ToDouble(_appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id).Sum(y => y.Alacak)),
                    GecikmeTutari = Convert.ToDouble(_appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id && y.HesapPlani.Aktif).Sum(y => y.GecikmeTutari)),
                    ToplamGecikmeTutari = Convert.ToDouble(_appDbContext.Fis.Where(f => f.HesapPlani.Aktif).Sum(y => y.GecikmeTutari)),
                    ToplamBorcTutari = Convert.ToDouble(_appDbContext.Fis.Where(f => f.HesapPlani.Aktif).Sum(y => y.Borc)),
                    ToplamAlacakTutari = Convert.ToDouble(_appDbContext.Fis.Where(f => f.HesapPlani.Aktif).Sum(y => y.Alacak)),
                    Aktif = x.Aktif
                })
                .OrderBy(h => h.Ad)
                .ToList();

            return View(firmalar);
        }

        [HttpPost]
        public EmptyResult SaveStatus(int companyId, bool status)
        {
            var firma = _appDbContext.HesapPlani.Find(companyId);
            firma.Aktif = status;
            _appDbContext.HesapPlani.Update(firma);
            _appDbContext.SaveChanges();
            return new EmptyResult();
        }

    }
}