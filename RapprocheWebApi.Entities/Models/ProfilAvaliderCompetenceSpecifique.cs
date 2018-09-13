using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilAvaliderCompetenceSpecifique
    {
        public Guid ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeurId { get; set; }
        public Guid CompetencesSpecifiquesCompetenceSpecifiqueId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesSpecifiques CompetencesSpecifiquesCompetenceSpecifique { get; set; }
        public ProfilsAvalider ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeur { get; set; }
    }
}
