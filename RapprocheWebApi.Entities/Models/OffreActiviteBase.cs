using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreActiviteBase
    {
        public Guid ActivitesBasesActiviteBaseId { get; set; }
        public Guid OffresOffreId { get; set; }
        public bool? ByOnline { get; set; }

        public ActivitesBases ActivitesBasesActiviteBase { get; set; }
        public Offres OffresOffre { get; set; }
    }
}
