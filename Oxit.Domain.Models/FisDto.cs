namespace Oxit.Domain.Models;

public class FisDto
{
    public string FirmaAdi { get; set; }
    public string CariKodu { get; set; }
    public string Aciklama { get; set; }
    public DateTime Tarih { get; set; }
    public Double? Borc { get; set; }
    public Double? Alacak { get; set; }
    public Double? GecikmeTutari { get; set; }
    public Int32? GecikenGun { get; set; }
}