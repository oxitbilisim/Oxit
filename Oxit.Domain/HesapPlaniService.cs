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
            List<Fis>? fisGecikme;
            var isHesapAktifmi = _dbContext.HesapPlani.Where(x => x.Aktif && x.Kod == hesapkodu);
           
            if (isHesapAktifmi.Count() > 0 )
            {  
              
                fisBorc = _dbContext.Fis
                        .Include(y => y.HesapPlani)
                        .Where(y => y.HesapPlani.Kod == hesapkodu && y.Borc > 0 && y.Tarih >= gecikmeBaslamaTarihi && !y.Odendi && y.FisTur == "3")
                        .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                        .ToList();
      
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
                var borcTutari = item.KalanBorcTutar > 0 ? (double)item.KalanBorcTutar : (double)item.Borc;
                int gecikmeGun = Convert.ToInt32((DateTime.Now - (DateTime)item.Tarih).TotalDays);

                if (gecikmeGun>= gecikmeGunu)
                {
                    if (_dbContext.Fis.Where(y => y.GecikmeFisId == item.Id).Any())
                    {  
                        _dbContext.Fis.Remove(_dbContext.Fis.Where(y => y.GecikmeFisId == item.Id).FirstOrDefault());
                        _dbContext.SaveChanges(); 
                        
                        Fis fis = new()
                        {
                            HesapPlaniId =item.HesapPlaniId,
                            Tarih = (DateTime) item.Tarih,
                            GecikmeTutari = Math.Round(((borcTutari * (double) gecikmeOrani) / 30) * (int) gecikmeGun, 2) *
                                            1.18,
                            GecikmeGunu = (int) gecikmeGun,
                            Odendi = false,
                            FisTur = "5",
                            GecikmeFisId = item.Id,
                            SonHesaplananGecikmeTarihi = DateTime.Now
                        };
                        _dbContext.Fis.Add(fis);
                        _dbContext.SaveChanges(); 
                    }
                    else
                    {
                        Fis fis = new()
                        {
                            HesapPlaniId =item.HesapPlaniId,
                            Tarih = (DateTime) item.Tarih,
                            GecikmeTutari = Math.Round(((borcTutari * (double) gecikmeOrani) / 30) * (int) gecikmeGun, 2) *
                                            1.18,
                            GecikmeGunu = (int) gecikmeGun,
                            Odendi = false,
                            FisTur = "5",
                            GecikmeFisId = item.Id,
                            SonHesaplananGecikmeTarihi = DateTime.Now
                        };
                        _dbContext.Fis.Add(fis);
                        _dbContext.SaveChanges(); 
                        
                    }
                 
                    
                   
                    
                     
             
                    // item.GeciktirilenAnaFaizTutar = (double)item.Borc;
                    // item.GeciktirilenTutar = item.KalanBorcTutar;
                    // item.GecikmeGunu = (int)gecikmeGun;
                    // // if (item.GecikmeTutari is null)
                    //     item.GecikmeTutari =
                    //         Math.Round(((borcTutari * (double) gecikmeOrani) / 30) * (int) gecikmeGun, 2) * 1.18;
                    // // else
                    // //     item.KalanGecikmeTutar = (double) item.KalanBorcTutar != (double) item.Borc
                    // //         ? Math.Round(((borcTutari * (double) gecikmeOrani) / 30) * (int) gecikmeGun, 2) * 1.18
                    // //         : 0;
                    //
                    // item.SonHesaplananGecikmeTarihi = DateTime.Now;
                }
               
                }
            }
            
            // alacak tutarından borc ve gecikmeleri düş 
            
            
            var fisAlacakList = _dbContext.Fis
                .Include(y => y.HesapPlani)
                .Where(y => y.HesapPlani.Kod == hesapkodu && y.Alacak > 0  && y.Tarih >= gecikmeBaslamaTarihi && !y.Odendi)
                .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                .ToList();


            foreach (var itemsAlacaks in fisAlacakList)
            {
                double? itemAlacakTutari = itemsAlacaks.Alacak;
               

            #region Gecikmeleri hesapla

            var fisGecikmes = _dbContext.Fis
                .Include(y => y.HesapPlani)
                .Where(y => y.HesapPlani.Kod == hesapkodu && y.Tarih >= gecikmeBaslamaTarihi  && y.GecikmeTutari != y.OdenenGecikmeTutar )
                .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                .ToList();

            foreach (var itemGecikme in fisGecikmes)
            {
                if (itemAlacakTutari > itemGecikme.GecikmeTutari)
                {
                    itemAlacakTutari = itemAlacakTutari - itemGecikme.GecikmeTutari;
                    itemGecikme.OdenenGecikmeTutar = itemGecikme.GecikmeTutari;
                    
                    //itemGecikme.Odendi = true;
                }else
                {
                 
                    itemGecikme.OdenenGecikmeTutar = itemGecikme.GecikmeTutari - itemAlacakTutari;
                    itemsAlacaks.KalanGecikmeTutar = itemsAlacaks.Alacak;
                    itemAlacakTutari = 0;
                }   
                itemsAlacaks.KalanAlacakTutar = itemAlacakTutari;
                _dbContext.SaveChanges();
            }
             #endregion
             
             #region Borcları hesapla

             var fisBorcs = _dbContext.Fis
                 .Include(y => y.HesapPlani)
                 .Where(y => y.HesapPlani.Kod == hesapkodu && y.Borc > 0 && !y.Odendi )
                 .OrderBy(y => y.Tarih).ThenBy(n => n.Id)
                 .ToList();

             foreach (var itemBorcs in fisBorcs)
             {
                 if (itemAlacakTutari > (itemBorcs.Borc - (itemBorcs.OdenenBorcTutar ?? 0 ) ) )
                 {
                     itemAlacakTutari = itemAlacakTutari - (itemBorcs.Borc - (itemBorcs.OdenenBorcTutar ?? 0 )  );
                     itemBorcs.OdenenBorcTutar = itemBorcs.Borc;
                     itemsAlacaks.KalanAlacakTutar = itemAlacakTutari > (itemBorcs.Borc ) 
                                           ? itemAlacakTutari - (itemBorcs.Borc - (itemBorcs.OdenenBorcTutar ?? 0 ) )
                                           : 0;
                     itemBorcs.KalanBorcTutar = 0;
                     
                     itemBorcs.Odendi =   true;
                 }else
                 {
                 
                     itemBorcs.OdenenBorcTutar = itemAlacakTutari;
                     itemBorcs.KalanBorcTutar = itemBorcs.Borc - itemAlacakTutari;
                     itemAlacakTutari = 0;
                     itemsAlacaks.Odendi = true;
                     itemBorcs.Odendi =  itemBorcs.Borc == itemBorcs.OdenenBorcTutar ? true : false;
                     itemBorcs.KalanBorcTutar = itemBorcs.KalanBorcTutar == itemBorcs.OdenenBorcTutar
                         ? 0
                         : itemBorcs.KalanBorcTutar;
                 }

                 itemsAlacaks.KalanBorcTutar = 0;
                 _dbContext.SaveChanges();
             }
             #endregion
            
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
