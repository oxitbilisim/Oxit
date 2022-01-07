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
            IMapper mapper

            )
        {
            _configuration = configuration;
            var cn = configuration.GetSection("cn2021").Value;
            _db = new TeknoparkContext(cn);
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index(int? page)
        {
            int totalCount = _appDbContext.Kira.Count();
            int recordsPerPage = 10;
            if (page == null)
                page = 1;
            int skip = (page.Value * recordsPerPage) - recordsPerPage;

            List<Kira> kiralar = _appDbContext.Kira

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

        private void update(KiraExcel model)
        {
            var oldData = _appDbContext.Kira.Find(model.Id);
            if (oldData != null)
            {
                oldData.FirmaAdi = model.FirmaAdi;
                oldData.Aciklama = model.Aciklama;
                oldData.BaslamaTarihi = DateOnly.Parse(model.BaslamaTarihi);
                oldData.BitisTarihi = DateOnly.Parse(model.BitisTarihi);
                oldData.IsletmeBedeli = model.IsletmeBedeli;
                oldData.IsletmeKDVToplam = model.IsletmeKDVToplam;
                oldData.KiraBedeli = model.KiraBedeli;
                oldData.KiraKDVToplam = model.KiraKDVToplam;
                oldData.KiraVeIsletmeKDVliToplam = model.KiraVeIsletmeKDVliToplam;
                oldData.KiraVeIsletmeKDVSizToplam = model.KiraVeIsletmeKDVSizToplam;
                oldData.Metrekare = model.Metrekare;
                oldData.MetrekareIsletmeFiyati = model.MetrekareIsletmeFiyati;
                oldData.MetrekareKiraFiyati = model.MetrekareKiraFiyati;
                _appDbContext.SaveChanges();

            }

        }

        private void insert(KiraExcel model)
        {
            _appDbContext.Kira.Add(new Kira
            {
                FirmaAdi = model.FirmaAdi,
                Aciklama = model.Aciklama,
                BaslamaTarihi = DateOnly.Parse(model.BaslamaTarihi),
                BitisTarihi = DateOnly.Parse(model.BitisTarihi),
                IsletmeBedeli = model.IsletmeBedeli,
                IsletmeKDVToplam = model.IsletmeKDVToplam,
                KiraBedeli = model.KiraBedeli,
                KiraKDVToplam = model.KiraKDVToplam,
                KiraVeIsletmeKDVliToplam = model.KiraVeIsletmeKDVliToplam,
                KiraVeIsletmeKDVSizToplam = model.KiraVeIsletmeKDVSizToplam,
                Metrekare = model.Metrekare,
                MetrekareIsletmeFiyati = model.MetrekareIsletmeFiyati,
                MetrekareKiraFiyati = model.MetrekareKiraFiyati
            });
            _appDbContext.SaveChanges();
        }
    }
}