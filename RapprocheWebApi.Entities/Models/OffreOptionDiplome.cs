using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreOptionDiplome
    {
        public Guid OffresOffreId { get; set; }
        public Guid OptionsDiplomesOptionDiplomeId { get; set; }
        public bool? ByOnline { get; set; }

        public Offres OffresOffre { get; set; }
        public OptionsDiplomes OptionsDiplomesOptionDiplome { get; set; }
    }
}
