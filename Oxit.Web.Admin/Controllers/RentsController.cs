using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;
using Oxit.Domain.Models;
using ExcelDataReader;
using System.Reflection;
using Oxit.Core.Utilities;
using Oxit.Domain.ViewModels.Kira;

namespace Oxit.Web.Admin.Controllers
{
    public partial class RentsController : Controller
    {
        private readonly TeknoparkContext db;
        private readonly IConfiguration configuration;
        private readonly appDbContext appDbContext;
        private static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        public RentsController(
            IConfiguration configuration,
            appDbContext appDbContext)
        {
            this.configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            this.db = new TeknoparkContext(cn);
            this.appDbContext = appDbContext;
        }
        [HttpGet]
        public IActionResult Index(int? page)
        {
            int totalCount = appDbContext.Kira.Count();
            int recordsPerPage = 10;
            if (page == null)
                page = 1;
            int skip = (page.Value * recordsPerPage) - recordsPerPage;

            List<Kira> kiralar = appDbContext.Kira
               
               .OrderBy(h => h.Id)
               .Skip(skip)
               .Take(recordsPerPage)
               .ToList();
     
            ViewData["pageCount"] = (totalCount + recordsPerPage - 1) / recordsPerPage;
            return View(kiralar);
        }

        [HttpGet, ActionName("Upload")]
        public IActionResult Upload_get()
        {
            return View();
        }
        [HttpPost, ActionName("Upload")]
        public async Task<IActionResult> Upload_pot(IFormFile kira)
        {
            if (kira.Length > 0)
            {
                MemoryStream ms = new MemoryStream();
                kira.CopyToAsync(ms);
                var excelData = ms.ExcelToObject<KiraExcel>();

                using (var tra = appDbContext.Database.BeginTransaction())
                {
                    try
                    {

                        appDbContext.Kira.RemoveRange(appDbContext.Kira);
                        appDbContext.SaveChanges();

                        foreach (var item in excelData)
                        {
                            appDbContext.Kira.Add(new Kira
                            {

                                FirmaAdi = item.FirmaAdi,
                                BaslamaTarihi = item.BaslamaTarihi,
                                BitisTarihi = item.BitisTarihi,
                                Metrekare = item.Metrekare,
                                MetrekareFiyati = item.MetrekareFiyati,
                                ToplamFiyat = item.ToplamFiyat,

                            });

                        }
                        appDbContext.SaveChanges();
                        tra.Commit();
                    }
                    catch (Exception ex)
                    {
                        tra.Rollback();
                        throw;
                    }
                }
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult GetFile()
        {
            return File(new FileStream("files\\kira.xlsx", FileMode.Open), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "kira.xlsx");
        }

    }
}