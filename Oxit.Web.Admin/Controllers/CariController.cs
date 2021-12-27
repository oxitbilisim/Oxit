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
    public class CariController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;
        
        public CariController(IConfiguration configuration, appDbContext appDbContext)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
            this.appDbContext = appDbContext;
           
        }
        public IActionResult Index(int? hesapId, int? page)
        {
            return View(commonParams(hesapId, page));
        }

        public IActionResult Edit(int? hesapId, int? page)
        {
            return View(commonParams(hesapId, page));
        }
        
        [HttpPost]
        public EmptyResult SaveStatus(int fisId, int status)
        {
            var fis = appDbContext.Fis.Find(fisId);
            fis.FisTip = (FisTip) status;
            appDbContext.Fis.Update(fis);
            appDbContext.SaveChanges();
            return new EmptyResult();
        }

        private Dictionary<string, object> commonParams(int? hesapId, int? page)
        {
            int totalCount = appDbContext.Fis.Where(f => f.HesapPlani.Id == hesapId).Count();
            int recordsPerPage = 10;
            if (page == null)
                page = 1;
            int skip = (page.Value * recordsPerPage) - recordsPerPage;

            List<Fis> fisList = appDbContext.Fis
                .Where(f => f.HesapPlani.Id == hesapId)
                .OrderByDescending(h => h.Tarih)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToList();
            
            HesapPlani hesapPlani = appDbContext.HesapPlani.FirstOrDefault(i => i.Id == hesapId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model["hesapPlani"] = hesapPlani;
            model["fisList"] = fisList;
            model["page"] = page;
            model["pageCount"] = (totalCount + recordsPerPage - 1) / recordsPerPage;

            return model;
        }
    }
}