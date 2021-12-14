using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class TbInvoiceSourceApp
    {
        public TbInvoiceSourceApp()
        {
            TbInvoiceHeads = new HashSet<TbInvoiceHead>();
        }

        public int InvoiceSourceAppId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TbInvoiceHead> TbInvoiceHeads { get; set; }
    }
}
