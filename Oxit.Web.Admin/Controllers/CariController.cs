using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Oxit.DataAccess.EntityFramework;
using Oxit.DataAccess.teknopark;
using System.Diagnostics;
using System.Transactions;
using OfficeOpenXml;
using Oxit.Domain.Models;

namespace Oxit.Web.Admin.Controllers
{
    public class CariController : Controller
    {
        private readonly TeknoparkContext _db;
        private readonly IConfiguration _configuration;
        private readonly appDbContext _appDbContext;
        
        public CariController(
            IConfiguration configuration,
            appDbContext appDbContext,
            TeknoparkContext db
            )
        {
            _configuration = configuration;
            _db = db;
            _appDbContext = appDbContext;
           
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
            var fis = _appDbContext.Fis.Find(fisId);
            fis.FisTip = (FisTip) status;
            _appDbContext.Fis.Update(fis);
            _appDbContext.SaveChanges();
            return new EmptyResult();
        }

        private Dictionary<string, object> commonParams(int? hesapId, int? page)
        {
            int totalCount = _appDbContext.Fis.Where(f => f.HesapPlani.Id == hesapId).Count();
            int recordsPerPage = 50;
            if (page == null)
                page = 1;
            int skip = (page.Value * recordsPerPage) - recordsPerPage;

            List<Fis> fisList = _appDbContext.Fis
                .Where(f => f.HesapPlani.Id == hesapId)
                .OrderByDescending(h => h.Tarih)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToList();
            
            HesapPlani hesapPlani = _appDbContext.HesapPlani.FirstOrDefault(i => i.Id == hesapId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model["hesapPlani"] = hesapPlani;
            model["fisList"] = fisList;
            model["page"] = page;
            model["pageCount"] = (totalCount + recordsPerPage - 1) / recordsPerPage;

            return model;
        }
        
        public IActionResult DownloadExcel(int hesapId)
        {
            List<Fis> fisList = _appDbContext.Fis
                .Where(f => f.HesapPlani.Id == hesapId)
                .OrderByDescending(h => h.Tarih)
                .ToList();

            List<FisDto> list = new List<FisDto>();
            foreach (var item in fisList)
            {
                HesapPlani hesapPlani = appDbContext.HesapPlani.FirstOrDefault(i => i.Id == hesapId);
                list.Add(new FisDto(){ FirmaAdi = hesapPlani.Ad,
                    CariKodu = hesapPlani.Kod,
                    Aciklama = item.Aciklama,
                    Borc = item.Borc,
                    Alacak = item.Alacak,
                    GecikmeTutari = item.GecikmeTutari,
                    GecikenGun = item.GecikmeGunu
                });
            }
            
            var stream = new MemoryStream();
            //required using OfficeOpenXml;
            // If you use EPPlus in a noncommercial context
            // according to the Polyform Noncommercial license:
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(list, true);
                package.Save();
            }
            stream.Position = 0;
            string excelName = $"UserList-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            return File(stream, "application/octet-stream", excelName);  
            //return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
        }
    }
}