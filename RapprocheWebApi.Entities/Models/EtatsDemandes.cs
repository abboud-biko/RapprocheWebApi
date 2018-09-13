using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EtatsDemandes
    {
        public Guid EtatDemandeId { get; set; }
        public DateTime Date { get; set; }
        public byte Etat { get; set; }
        public bool Actuel { get; set; }
        public Guid DemandeId { get; set; }
        public bool? ByOnline { get; set; }

        public Demandes Demande { get; set; }
    }
}
