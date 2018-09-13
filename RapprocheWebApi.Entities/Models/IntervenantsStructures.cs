using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class IntervenantsStructures
    {
        public Guid IntervenantStructureId { get; set; }
        public Guid UserId { get; set; }
        public Guid StructureId { get; set; }
        public DateTime Date { get; set; }
        public bool Actuelle { get; set; }
        public bool? ByOnline { get; set; }

        public Structures Structure { get; set; }
        public Intervenants User { get; set; }
    }
}
