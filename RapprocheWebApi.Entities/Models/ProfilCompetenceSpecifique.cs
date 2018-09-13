using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilCompetenceSpecifique
    {
        public Guid ProfilsDemandeurId { get; set; }
        public Guid CompetencesSpecifiquesCompetenceSpecifiqueId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesSpecifiques CompetencesSpecifiquesCompetenceSpecifique { get; set; }
        public Profils ProfilsDemandeur { get; set; }
    }
}
