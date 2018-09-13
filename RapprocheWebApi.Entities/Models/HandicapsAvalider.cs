using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class HandicapsAvalider
    {
        public Guid HandicapId { get; set; }
        public string Taux { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid TypeHandicapId { get; set; }
        public bool? ByOnline { get; set; }

        public DemandeursAvalider Demandeur { get; set; }
        public TypesHandicaps TypeHandicap { get; set; }
    }
}
