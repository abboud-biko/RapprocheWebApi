using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class TypesContratReconduction
    {
        public Guid TypesContratsSourceReconductionTypeContratId { get; set; }
        public Guid TypesContratsEligiblesReconductionTypeContratId { get; set; }

        public TypesContrats TypesContratsEligiblesReconductionTypeContrat { get; set; }
        public TypesContrats TypesContratsSourceReconductionTypeContrat { get; set; }
    }
}
