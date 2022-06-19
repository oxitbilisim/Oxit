using AutoMapper;
using Oxit.Domain.Models;
using Microsoft.Extensions.Configuration;
using Oxit.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Oxit.Domain
{
    public class HesapPlaniService
    {

        private readonly appDbContext _dbContext;
        private readonly IConfiguration _configuration;
        public HesapPlaniService(IMapper mapper,
                                 IConfiguration configuration,
                                 appDbContext appDbContext)
        {
            _configuration = configuration;
            _dbContext = appDbContext;
        }

        public void GecikmeleriHesapla(string? hesapkodu)
        {
            var gecikmeOrani = Convert.ToDecimal(_configuration.GetSection("gecikmeOrani").Value);
            var gecikmeGunu = Convert.ToInt32(_configuration.GetSection("gecikmeGunu").Value);
            var gecikmeBaslamaTarihi = Convert.ToDateTime(_configuration.GetSection("gecikmeBaslamaTarihi").Value);
            
            List<Fis>? fisBorc;

            var isHesapAktifmi = _dbContext.HesapPlani.Where(x => x.Aktif && x.Kod == hesapkodu);
           
            if (isHesapAktifmi.Count() > 0 )
            {  
            if (string.IsNullOrEmpty(hesapkodu))
            {
                fisBorc = _dbContext.Fis
                                        .Include(y => y.HesapPlani)
                                        .Where(y => y.Borc > 0 && !y.Odendi && y.FisTur == "3" && y.Tarih >= gecikmeBaslamaTarihi)
                                        .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                                        .ToList();
            }
            else
            {
                fisBorc = _dbContext.Fis
                        .Include(y => y.HesapPlani)
                        .Where(y => y.HesapPlani.Kod == hesapkodu && y.Borc > 0 && !y.Odendi && y.FisTur == "3")
                        .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                        .ToList();
            }

            foreach (var item in fisBorc)
            {
                var AlacakT = _dbContext.Fis
                    .Include(y => y.HesapPlani)
                    .Where(y => y.HesapPlani.Kod == hesapkodu &&  y.Tarih > item.Tarih  && y.Alacak > 0 && !y.Odendi && y.FisTur == "3" 
                                && y.Tarih >= gecikmeBaslamaTarihi)
                    .OrderBy(y => y.Tarih).FirstOrDefault();
                    
                if ( ((
                        AlacakT == null ?  DateTime.Now : (DateTime)AlacakT.Tarih) - (DateTime)item.Tarih).TotalDays > gecikmeGunu)
                { 
                var borcTutari = item.KalanTutar > 0 ? (double)item.KalanTutar : (double)item.Borc;
                var gecikmeGun = (DateTime.Now - (DateTime)item.Tarih).TotalDays;

                if (gecikmeGun >= gecikmeGunu)
                {
                    item.GeciktirilenAnaFaizTutar = (double)item.Borc;
                    item.GeciktirilenTutar = item.KalanTutar;
                    item.GecikmeGunu = (int)gecikmeGun;
                    item.GecikmeTutari = Math.Round(((borcTutari * (double)gecikmeOrani) / 30) * (int)gecikmeGun, 2) * 1.18;
                    item.SonHesaplananGecikmeTarihi = DateTime.Now;
                }
                _dbContext.SaveChanges();
                }
            }
            }
        }
        public void AlacaksizGecikmeHesapla(string? hesapkodu)
        {
            var gecikmeOrani = Convert.ToDecimal(_configuration.GetSection("gecikmeOrani").Value);
            var gecikmeGunu = Convert.ToInt32(_configuration.GetSection("gecikmeGunu").Value);
            var gecikmeBaslamaTarihi = Convert.ToDateTime(_configuration.GetSection("gecikmeBaslamaTarihi").Value);

            List<Fis>? fisBorc;
            if (string.IsNullOrEmpty(hesapkodu))
            {
                fisBorc = _dbContext.Fis
                      .Include(y => y.HesapPlani)
                      .Where(y => y.Borc > 0 && !y.Odendi  && y.FisTur == "3" && y.Tarih >= gecikmeBaslamaTarihi)
                      .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                      .ToList();
            }
            else
            {
                fisBorc = _dbContext.Fis
                        .Include(y => y.HesapPlani)
                        .Where(y => y.HesapPlani.Kod == hesapkodu  && y.FisTur == "3"
                                                                   && y.Tarih >= gecikmeBaslamaTarihi
                                                                   && y.Borc > 0 && !y.Odendi)
                        .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                        .ToList();
            }

            foreach (var item in fisBorc)
            {

                var borcTutari = item.KalanTutar > 0 ? (double)item.KalanTutar : (double)item.Borc;
                var gecikmeGun = (DateTime.Now - (DateTime)item.Tarih).TotalDays;

                if (gecikmeGun >= gecikmeGunu)
                {
                    item.GeciktirilenAnaFaizTutar = (double)item.Borc;
                    item.GeciktirilenTutar = item.KalanTutar;
                    item.GecikmeGunu = (int)gecikmeGun;
                    item.GecikmeTutari = Math.Round(((borcTutari * (double)gecikmeOrani) / 30) * (int)gecikmeGun, 2);
                    item.SonHesaplananGecikmeTarihi = DateTime.Now;
                }
                _dbContext.SaveChanges();
            }

        }
    }
}
