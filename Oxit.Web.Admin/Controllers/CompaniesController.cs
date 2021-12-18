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

        public CompaniesController(IConfiguration configuration, appDbContext appDbContext)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
            this.appDbContext = appDbContext;
        }
        public IActionResult Index(int? page, string name = "")
        {
            int totalCount = appDbContext.HesapPlani.Count();
            int recordsPerPage = 10;
            if (page == null)
                page = 1;
            int skip = (page.Value * recordsPerPage) - recordsPerPage;
            
            
            
            List<HesapPlani> firmalar = appDbContext.HesapPlani
                //.Where(h => EF.Functions.ILike(EF.Functions.Collate(h.Ad,"tr_TR"),"ma"))
                .OrderBy(h => h.Ad)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToList();
            //firmalar = firmalar.Where(f => f.Ad.Contains(name)).ToList();

            Dictionary<string, object> model = new Dictionary<string, object>();
            model["companies"] = firmalar;
            model["pageCount"] = (totalCount + recordsPerPage - 1) / recordsPerPage;
            return View(model);
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