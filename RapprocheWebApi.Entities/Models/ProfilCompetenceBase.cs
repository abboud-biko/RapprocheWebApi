using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilCompetenceBase
    {
        public Guid ProfilsDemandeurId { get; set; }
        public Guid CompetencesBaseCompetenceBaseId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesBases CompetencesBaseCompetenceBase { get; set; }
        public Profils ProfilsDemandeur { get; set; }
    }
}
