using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Postulations
    {
        public Guid PostulationId { get; set; }
        public DateTime DatePostulation { get; set; }
        public string Motif { get; set; }
        public Guid DemandeId { get; set; }
        public Guid OffreId { get; set; }
        public byte Etat { get; set; }
        public bool? ByOnline { get; set; }

        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
    }
}
