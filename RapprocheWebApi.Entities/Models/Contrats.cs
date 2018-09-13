using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Contrats
    {
        public Contrats()
        {
            ContratsFormation = new HashSet<ContratsFormation>();
            EtatsContrat = new HashSet<EtatsContrat>();
            InverseContratInitialContrat = new HashSet<Contrats>();
        }

        public Guid ContratId { get; set; }
        public string Numero { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public byte Etat { get; set; }
        public string CauseResiliation { get; set; }
        public Guid DossierDaipId { get; set; }
        public Guid TypeContratId { get; set; }
        public DateTime? DateResiliation { get; set; }
        public decimal? Salaire { get; set; }
        public decimal MontantAide { get; set; }
        public Guid? RaisonSortieDispositifId { get; set; }
        public Guid? ContratInitialContratId { get; set; }
        public Guid DossierDaipDossierDaipId { get; set; }

        public Contrats ContratInitialContrat { get; set; }
        public DossiersDaips DossierDaipDossierDaip { get; set; }
        public RaisonsSortieDispositif RaisonSortieDispositif { get; set; }
        public TypesContrats TypeContrat { get; set; }
        public ICollection<ContratsFormation> ContratsFormation { get; set; }
        public ICollection<EtatsContrat> EtatsContrat { get; set; }
        public ICollection<Contrats> InverseContratInitialContrat { get; set; }
    }
}
