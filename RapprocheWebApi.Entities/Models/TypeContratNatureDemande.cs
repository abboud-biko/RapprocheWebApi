using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class TypeContratNatureDemande
    {
        public Guid TypesContratTypeContratId { get; set; }
        public Guid NaturesDemandeNatureDemandeId { get; set; }

        public NaturesDemandes NaturesDemandeNatureDemande { get; set; }
        public TypesContrats TypesContratTypeContrat { get; set; }
    }
}
