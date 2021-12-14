using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbInvoiceHead
    {
        public TbInvoiceHead()
        {
            TbInvoiceLines = new HashSet<TbInvoiceLine>();
        }

        public int InvoiceHeadId { get; set; }
        public string? MongoId { get; set; }
        public int SourceCompanyId { get; set; }
        public string RefId { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public string InvoiceType { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public double? ExchangeRate { get; set; }
        public bool IsOpen { get; set; }
        public string? FirmCode { get; set; }
        public string? FirmTitle { get; set; }
        public string? FirmTaxId { get; set; }
        public string? CashCode { get; set; }
        public string? BankCode { get; set; }
        public bool IsDomestic { get; set; }
        public string? DepartmentCode { get; set; }
        public double GrandTotalTl { get; set; }
        public double? GrandTotalExc { get; set; }
        public double? VatTl { get; set; }
        public double? VatExc { get; set; }
        public int? DocumentStatusId { get; set; }
        public string? RejectDescription { get; set; }
        public int? FisBilRefNo { get; set; }
        public int InvoiceSourceAppId { get; set; }
        public bool IsArchived { get; set; }
        public string? InvoiceFormat { get; set; }
        public double? OtherTaxTl { get; set; }
        public double? OtherTaxExc { get; set; }

        public virtual TbInvoiceSourceApp InvoiceSourceApp { get; set; } = null!;
        public virtual ICollection<TbInvoiceLine> TbInvoiceLines { get; set; }
    }
}
