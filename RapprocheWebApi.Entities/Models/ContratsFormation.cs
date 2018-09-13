using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ContratsFormation
    {
        public Guid ContratFormationId { get; set; }
        public string Numero { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string OrganismeFormateur { get; set; }
        public string Domaine { get; set; }
        public string MontantFormation { get; set; }
        public string MontantAide { get; set; }
        public string PourcentageAide { get; set; }
        public Guid ContratId { get; set; }
        public Guid DossierDaipDossierDaipId { get; set; }

        public Contrats Contrat { get; set; }
        public DossiersDaips DossierDaipDossierDaip { get; set; }
    }
}
