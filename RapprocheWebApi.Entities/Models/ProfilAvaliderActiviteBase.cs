using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilAvaliderActiviteBase
    {
        public Guid ProfilAvaliderActiviteBaseActiviteBaseDemandeurId { get; set; }
        public Guid ActivitesBaseActiviteBaseId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesBases ActivitesBaseActiviteBase { get; set; }
        public ProfilsAvalider ProfilAvaliderActiviteBaseActiviteBaseDemandeur { get; set; }
    }
}
