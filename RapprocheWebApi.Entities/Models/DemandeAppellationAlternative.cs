using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class DemandeAppellationAlternative
    {
        public Guid DemandesDemandeId { get; set; }
        public Guid MetiersAlternatifsAppellationId { get; set; }
        public bool? ByOnline { get; set; }
        public DateTime? DateEnregistrement { get; set; }

        public Demandes DemandesDemande { get; set; }
        public Appellations MetiersAlternatifsAppellation { get; set; }
    }
}
