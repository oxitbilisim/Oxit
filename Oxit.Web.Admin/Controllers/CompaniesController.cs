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
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;

        public CompaniesController(
            IConfiguration configuration,
            appDbContext appDbContext,
            TeknoparkContext db
            )
        {
            this.configuration = configuration;
            this.db = db;
            this.appDbContext = appDbContext;
        }
        public IActionResult Index(string name, string kod)
        {
            List<HesapPlani> firmalar = appDbContext.HesapPlani
                .Select(x => new HesapPlani
                {
                    Id = x.Id,
                    Ad = x.Ad,
                    Kod = x.Kod,
                    GecikmeTutari = appDbContext.Fis.Where(y => y.HesapPlaniId == x.Id).Sum(y => y.GecikmeTutari),
                    Aktif = x.Aktif
                })
                .OrderBy(h => h.Ad)
                .ToList();

            return View(firmalar);
        }
        
        [HttpPost]
        public EmptyResult SaveStatus(int companyId, bool status)
        {
            var firma = appDbContext.HesapPlani.Find(companyId);
            firma.Aktif = status;
            appDbContext.HesapPlani.Update(firma);
            appDbContext.SaveChanges();
            return new EmptyResult();
        }
      
    }
}