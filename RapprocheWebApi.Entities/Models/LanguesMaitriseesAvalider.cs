using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class LanguesMaitriseesAvalider
    {
        public Guid LangueMaitriseeId { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid LangueId { get; set; }
        public byte NiveauMaitrise { get; set; }
        public bool? ByOnline { get; set; }

        public ProfilsAvalider Demandeur { get; set; }
        public Langues Langue { get; set; }
    }
}
