using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EtatsContrat
    {
        public Guid EtatContratId { get; set; }
        public short Etat { get; set; }
        public DateTime Date { get; set; }
        public bool IsActuelle { get; set; }
        public Guid ContratId { get; set; }

        public Contrats Contrat { get; set; }
    }
}
