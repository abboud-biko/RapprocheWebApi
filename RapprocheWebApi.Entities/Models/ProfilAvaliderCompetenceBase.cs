using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilAvaliderCompetenceBase
    {
        public Guid ProfilAvaliderCompetenceBaseCompetenceBaseDemandeurId { get; set; }
        public Guid CompetencesBaseCompetenceBaseId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesBases CompetencesBaseCompetenceBase { get; set; }
        public ProfilsAvalider ProfilAvaliderCompetenceBaseCompetenceBaseDemandeur { get; set; }
    }
}
