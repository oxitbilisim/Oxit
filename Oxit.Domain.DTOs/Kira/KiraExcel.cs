namespace Oxit.Domain.ViewModels.Kira
{
    public class KiraExcel
    {
        public int? Id { get; set; }
        public string? FirmaAdi { get; set; }
        public double? Metrekare { get; set; }
        public string? BaslamaTarihi { get; set; }
        public string? BitisTarihi { get; set; }

        public double? KiraBedeli { get; set; }
        public double? IsletmeBedeli { get; set; }
        public double? MetrekareKiraFiyati { get; set; }
        public double? MetrekareIsletmeFiyati { get; set; }


        public double? KiraKDVToplam { get; set; }
        public double? IsletmeKDVToplam { get; set; }

        public double? KiraVeIsletmeKDVliToplam { get; set; }
        public double? KiraVeIsletmeKDVSizToplam { get; set; }

        public string? Aciklama { get; set; }
    }



}