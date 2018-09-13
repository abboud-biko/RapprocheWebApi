using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OffreStructureCompensation
    {
        public Guid OffresCompenseesOffreId { get; set; }
        public Guid StructuresCompensationStructureId { get; set; }
        public bool? ByOnline { get; set; }

        public Offres OffresCompenseesOffre { get; set; }
        public Structures StructuresCompensationStructure { get; set; }
    }
}
