using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilAvaliderActiviteSpecifique
    {
        public Guid ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeurId { get; set; }
        public Guid ActivitesSpecifiquesActiviteSpecifiqueId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesSpecifiques ActivitesSpecifiquesActiviteSpecifique { get; set; }
        public ProfilsAvalider ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeur { get; set; }
    }
}
