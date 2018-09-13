using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Rapprochements
    {
        public Guid RapprochementId { get; set; }
        public Guid OffreId { get; set; }
        public Guid DemandeId { get; set; }
        public double TauxRapprochement { get; set; }
        public short EtatProgression { get; set; }
        public bool? ByOnline { get; set; }

        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
    }
}
