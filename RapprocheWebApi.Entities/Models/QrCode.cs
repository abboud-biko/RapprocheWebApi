using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class QrCode
    {
        public Guid Id { get; set; }
        public string Qrcode1 { get; set; }
        public int? TypeDoc { get; set; }
    }
}
