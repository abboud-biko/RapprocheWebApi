using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreCompetenceBase
    {
        public Guid CompetencesBasesCompetenceBaseId { get; set; }
        public Guid OffresOffreId { get; set; }
        public bool? ByOnline { get; set; }

        public CompetencesBases CompetencesBasesCompetenceBase { get; set; }
        public Offres OffresOffre { get; set; }
    }
}
