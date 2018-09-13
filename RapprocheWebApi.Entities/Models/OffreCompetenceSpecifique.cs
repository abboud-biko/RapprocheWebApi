using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreCompetenceSpecifique
    {
        public Guid CompetencesSpecifiquesCompetenceSpecifiqueId { get; set; }
        public Guid OffresOffreId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesSpecifiques CompetencesSpecifiquesCompetenceSpecifique { get; set; }
        public Offres OffresOffre { get; set; }
    }
}
