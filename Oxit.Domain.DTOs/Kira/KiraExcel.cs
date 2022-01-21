namespace Oxit.Domain.ViewModels.Kira
{
    public class KiraExcel
    {
        public int? Id { get; set; }
        public string? FirmaAdi { get; set; }
        public double? Metrekare { get; set; }

        public string? BaslamaTarihi { get; set; }
        public string? BitisTarihi { get; set; }

  

        public double? MetrekareKiraFiyati { get; set; }
        public double? MetrekareIsletmeFiyati { get; set; }

        public double? KiraKDVOrani { get; set; } 
        public double? IsletmeKDVOrani { get; set; }

        public string? Aciklama { get; set; }
    }



}