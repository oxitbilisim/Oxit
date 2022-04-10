using AutoMapper;
using Oxit.Common.DataAccess.EntityFramework;
using Oxit.Common.Domain.Base;
using Oxit.Common.Models;
using Oxit.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Oxit.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Oxit.Domain
{
    public class HesapPlaniService
    {

        private readonly appDbContext _dbContext;
        private readonly IMapper mapper;
        private readonly IConfiguration _configuration;
        public HesapPlaniService(IMapper mapper,
                                 IConfiguration configuration,
                                 appDbContext appDbContext)
        {

            this.mapper = mapper;
            _configuration = configuration;
            _dbContext = appDbContext;
        }

        public void GecikmeleriHesapla(string? hesapkodu)
        {
            var gecikmeOrani = Convert.ToDecimal(_configuration.GetSection("gecikmeOrani").Value);
            var gecikmeGunu = Convert.ToInt32(_configuration.GetSection("gecikmeGunu").Value);
            List<Fis>? fisBorc;

            if (string.IsNullOrEmpty(hesapkodu))
            {
                fisBorc = _dbContext.Fis
                                        .Include(y => y.HesapPlani)
                                        .Where(y => y.Borc > 0 && !y.Odendi && y.FisTur == "3")
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
        public void AlacaksizGecikmeHesapla(string? hesapkodu)
        {
            var gecikmeOrani = Convert.ToDecimal(_configuration.GetSection("gecikmeOrani").Value);
            var gecikmeGunu = Convert.ToInt32(_configuration.GetSection("gecikmeGunu").Value);

            List<Fis>? fisBorc;
            if (string.IsNullOrEmpty(hesapkodu))
            {
                fisBorc = _dbContext.Fis
                      .Include(y => y.HesapPlani)
                      .Where(y => y.Borc > 0 && !y.Odendi  && y.FisTur == "3" )
                      .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                      .ToList();
            }
            else
            {
                fisBorc = _dbContext.Fis
                        .Include(y => y.HesapPlani)
                        .Where(y => y.HesapPlani.Kod == hesapkodu  && y.FisTur == "3"
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
