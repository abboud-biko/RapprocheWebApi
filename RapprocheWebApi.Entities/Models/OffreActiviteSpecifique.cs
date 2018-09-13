using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreActiviteSpecifique
    {
        public Guid ActivitesSpecifiquesActiviteSpecifiqueId { get; set; }
        public Guid OffresOffreId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesSpecifiques ActivitesSpecifiquesActiviteSpecifique { get; set; }
        public Offres OffresOffre { get; set; }
    }
}
