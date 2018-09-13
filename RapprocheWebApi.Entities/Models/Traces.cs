using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Traces
    {
        public Guid TraceId { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
        public string Machine { get; set; }
        public string NomAction { get; set; }
        public DateTime Date { get; set; }
        public string EntitySet { get; set; }
        public Guid EntityId { get; set; }
        public string ParentEntitySet { get; set; }
        public Guid? ParentEntityId { get; set; }
        public Guid StructureId { get; set; }
        public Guid UserId { get; set; }

        public Structures Structure { get; set; }
        public Intervenants User { get; set; }
    }
}
