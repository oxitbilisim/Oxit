using System;
using System.Collections.Generic;

namespace Oxit.DataAccess.teknopark
{
    public partial class LogUyari
    {
        public int Id { get; set; }
        public string? Mesaj { get; set; }
        public string? Kullanici { get; set; }
        public DateTime? Sqltar { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Modul { get; set; }
        public Guid? Guid { get; set; }
    }
}
