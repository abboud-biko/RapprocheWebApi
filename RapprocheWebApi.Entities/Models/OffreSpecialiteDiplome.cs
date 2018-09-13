using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreSpecialiteDiplome
    {
        public Guid OffresOffreId { get; set; }
        public Guid SpecialitesDiplomesSpecialiteDiplomeId { get; set; }
        public bool? ByOnline { get; set; }

        public Offres OffresOffre { get; set; }
        public SpecialitesDiplomes SpecialitesDiplomesSpecialiteDiplome { get; set; }
    }
}
