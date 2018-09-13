using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Formations
    {
        public Guid FormationId { get; set; }
        public string Intitule { get; set; }
        public string Etablissement { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Guid DemandeurId { get; set; }
        public bool? ByOnline { get; set; }

        public Profils Demandeur { get; set; }
    }
}
