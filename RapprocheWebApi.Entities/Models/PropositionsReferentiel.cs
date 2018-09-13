using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class PropositionsReferentiel
    {
        public Guid PropositionReferentielId { get; set; }
        public string NomReferentiel { get; set; }
        public string IntitulePropose { get; set; }
        public string DetailProposition { get; set; }
        public Guid StructureId { get; set; }
        public Guid UserId { get; set; }

        public Structures Structure { get; set; }
        public Intervenants User { get; set; }
    }
}
