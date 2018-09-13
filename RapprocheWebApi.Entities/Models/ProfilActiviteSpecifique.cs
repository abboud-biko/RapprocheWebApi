using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilActiviteSpecifique
    {
        public Guid ProfilsDemandeurId { get; set; }
        public Guid ActivitesSpecifiquesActiviteSpecifiqueId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesSpecifiques ActivitesSpecifiquesActiviteSpecifique { get; set; }
        public Profils ProfilsDemandeur { get; set; }
    }
}
