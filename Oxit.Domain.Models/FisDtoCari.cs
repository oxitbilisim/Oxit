namespace Oxit.Domain.Models;

public class FisDtoCari
{
    public int Id { get; set; }
    public string Aciklama { get; set; }
    public int HesapPlaniId { get; set; }
    public DateTime Tarih { get; set; }
    public DateTime? SonHesaplananGecikmeTarihi { get; set; }
    public Double Borc { get; set; }
    public Double Alacak { get; set; }
    public Double GecikmeTutari { get; set; }
    public Int32 GecikenGun { get; set; }
    public bool Odendi { get; set; }
    
}