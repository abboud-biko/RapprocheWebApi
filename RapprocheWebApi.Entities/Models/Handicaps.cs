using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Handicaps
    {
        public Guid HandicapId { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid TypeHandicapId { get; set; }
        public string Taux { get; set; }
        public bool? ByOnline { get; set; }

        public Demandeurs Demandeur { get; set; }
        public TypesHandicaps TypeHandicap { get; set; }
    }
}
