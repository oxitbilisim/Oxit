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
using AutoMapper;

namespace Oxit.Web.Admin.Controllers
{
    public partial class RentsController : Controller
    {
        private readonly TeknoparkContext _db;
        private readonly IConfiguration _configuration;
        private readonly appDbContext _appDbContext;
        private readonly IMapper _mapper;
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
            appDbContext appDbContext,
            IMapper mapper,
            TeknoparkContext db
            )
        {
            _configuration = configuration;
            _db = db;
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
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

                using (var tra = _appDbContext.Database.BeginTransaction())
                {
                    try
                    {

                        _appDbContext.Kira.RemoveRange(_appDbContext.Kira);
                        _appDbContext.SaveChanges();

                        foreach (var item in excelData)
                        {
                            _appDbContext.Kira.Add(new Kira
                            {

                                FirmaAdi = item.FirmaAdi,
                                // BaslamaTarihi = item.BaslamaTarihi,
                                //  BitisTarihi = item.BitisTarihi,
                                Metrekare = item.Metrekare,
                                //MetrekareFiyati = item.MetrekareFiyati,
                                //  ToplamFiyat = item.ToplamFiyat,

                            });

                        }
                        _appDbContext.SaveChanges();
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

        [HttpGet, ActionName("Save")]
        public IActionResult Save_Get(int? Id)
        {
            if (Id == null)
                return View();

            var data = _appDbContext.Kira.Find(Id);
            if (data == null)
                return RedirectToAction("index");
            return View(data);

        }

        [HttpPost, ActionName("Save")]
        public IActionResult Save_Post(KiraExcel model)
        {

            if (model.Id is not null or > 0)
                update(model);
            else
                insert(model);

            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            _appDbContext.Kira.Remove(_appDbContext.Kira.Find(Id));
            _appDbContext.SaveChanges();
            return RedirectToAction("index");

        }

        [HttpGet]
        public JsonResult GetRents(int take, int skip, int page, int pagesize)
        {

            List<Kira> kiralar = _appDbContext
                .Kira
             .OrderBy(h => h.Id)
             .Skip(skip)
             .Take(take)
             .ToList();

            return Json(new
            {
                Data = kiralar,
                Total = _appDbContext.Kira.Count(),
                Page = page,


            });
        }

        private void update(KiraExcel model)
        {
            var oldData = _appDbContext.Kira.Find(model.Id);
            if (oldData != null)
            {
                oldData.FirmaAdi = model.FirmaAdi;
                oldData.Aciklama = model.Aciklama??String.Empty;
                oldData.BaslamaTarihi = DateOnly.Parse(model.BaslamaTarihi);
                oldData.BitisTarihi = DateOnly.Parse(model.BitisTarihi);
                oldData.Metrekare = model.Metrekare;
                oldData.MetrekareIsletmeFiyati = model.MetrekareIsletmeFiyati;
                oldData.MetrekareKiraFiyati = model.MetrekareKiraFiyati;
                oldData.KiraKDVOrani = model.KiraKDVOrani;
                oldData.IsletmeKDVOrani = model.IsletmeKDVOrani;
                oldData.IsletmeBedeli = model.Metrekare * model.MetrekareIsletmeFiyati;
                oldData.KiraBedeli = model.Metrekare * model.MetrekareKiraFiyati;

                _appDbContext.SaveChanges();

            }

        }

        private void insert(KiraExcel model)
        {
            _appDbContext.Kira.Add(new Kira
            {
                FirmaAdi = model.FirmaAdi,
                Aciklama = model.Aciklama ?? String.Empty,
                BaslamaTarihi = DateOnly.Parse(model.BaslamaTarihi),
                BitisTarihi = DateOnly.Parse(model.BitisTarihi),
                Metrekare = model.Metrekare,
                MetrekareIsletmeFiyati = model.MetrekareIsletmeFiyati,
                MetrekareKiraFiyati = model.MetrekareKiraFiyati,
                IsletmeBedeli = model.Metrekare * model.MetrekareIsletmeFiyati,
                KiraBedeli = model.Metrekare * model.MetrekareKiraFiyati,
                IsletmeKDVOrani = model.IsletmeKDVOrani,
                KiraKDVOrani = model.KiraKDVOrani,
            });
            _appDbContext.SaveChanges();
        }
    }
}