using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilActiviteBase
    {
        public Guid ProfilsDemandeurId { get; set; }
        public Guid ActivitesBaseActiviteBaseId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesBases ActivitesBaseActiviteBase { get; set; }
        public Profils ProfilsDemandeur { get; set; }
    }
}
