using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Rapprochements
    {
        public Guid RapprochementId { get; set; }
        [JsonIgnore]
        public Guid OffreId { get; set; }
        [JsonIgnore]
        public Guid DemandeId { get; set; }
        public double TauxRapprochement { get; set; }
        [JsonIgnore]
        public short EtatProgression { get; set; }
        [JsonIgnore]
        public bool? ByOnline { get; set; }

        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
    }
}
