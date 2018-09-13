using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ExperiencesAvalider
    {
        public Guid ExperienceId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public byte? CauseRupture { get; set; }
        public string Organisme { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid PosteOccupeId { get; set; }
        public bool? ByOnline { get; set; }

        public ProfilsAvalider Demandeur { get; set; }
        public Appellations PosteOccupe { get; set; }
    }
}
