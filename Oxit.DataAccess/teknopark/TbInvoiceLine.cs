using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbInvoiceLine
    {
        public int InvoiceLineId { get; set; }
        public int InvoiceHeadId { get; set; }
        public string PseType { get; set; } = null!;
        public string? PseCode { get; set; }
        public string PseName { get; set; } = null!;
        public double Quantity { get; set; }
        public string Unit { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public double UnitPriceTl { get; set; }
        public double? UnitPriceExc { get; set; }
        public double TotalTl { get; set; }
        public double? TotalExc { get; set; }
        public double? VatRate { get; set; }
        public double? VatTl { get; set; }
        public double? VatExc { get; set; }
        public double? OtvTl { get; set; }
        public double? OtvExc { get; set; }
        public string? VatWitholdingRate { get; set; }
        public double? VatWitholdingTl { get; set; }
        public double? VatWitholdingExc { get; set; }
        public double? DiscountTl { get; set; }
        public double? DiscountExc { get; set; }
        public double NetAmountTl { get; set; }
        public double? NetAmountExc { get; set; }
        public double? WitholdingTaxTl { get; set; }
        public double? WitholdingTaxExc { get; set; }
        public double? FonTl { get; set; }
        public double? FonExc { get; set; }
        public double? BagkurTl { get; set; }
        public double? BagkurExc { get; set; }
        public double? MeraTl { get; set; }
        public double? BorsaTl { get; set; }
        public double? BorsaExc { get; set; }
        public double? OivTl { get; set; }
        public double? OivExc { get; set; }
        public double? Tax0021 { get; set; }
        public double? Tax0061 { get; set; }
        public double? Tax1047 { get; set; }
        public double? Tax1048 { get; set; }
        public double? Tax4071 { get; set; }
        public double? Tax8001 { get; set; }
        public double? Tax8002 { get; set; }
        public double? Tax8004 { get; set; }
        public double? Tax8005 { get; set; }
        public double? Tax8006 { get; set; }
        public double? Tax8007 { get; set; }
        public double? Tax8008 { get; set; }
        public double? Tax9021 { get; set; }
        public double? Navlun { get; set; }
        public double? NavlunKdv { get; set; }
        public double? HalRusum { get; set; }
        public double? HalRusumKdv { get; set; }
        public double? MusRusum { get; set; }
        public double? MusRusumKdv { get; set; }
        public double? Rehin { get; set; }
        public double? RehinKdv { get; set; }
        public double? Sandik { get; set; }
        public double? SandikKdv { get; set; }
        public double? HalKomisyon { get; set; }
        public double? HalKomisyonKdv { get; set; }
        public double? Hammaliye { get; set; }
        public double? HammaliyeKdv { get; set; }
        public double? Diger { get; set; }
        public double? DigerKdv { get; set; }

        public virtual TbInvoiceHead InvoiceHead { get; set; } = null!;
    }
}
