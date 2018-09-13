using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class DemandeursStructures
    {
        public Guid DemandeurStructureId { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid StructureId { get; set; }
        public bool Actuelle { get; set; }
        public DateTime Date { get; set; }
        public bool? ByOnline { get; set; }

        public Demandeurs Demandeur { get; set; }
        public Structures Structure { get; set; }
    }
}
