using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffresLangues
    {
        public Guid OffreLangueId { get; set; }
        public Guid LangueId { get; set; }
        public Guid OffreId { get; set; }
        public byte NiveauMaitrise { get; set; }
        public bool? ByOnline { get; set; }

        public Langues Langue { get; set; }
        public Offres Offre { get; set; }
    }
}
