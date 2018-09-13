using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Sequences
    {
        public Guid SequenceId { get; set; }
        public string EntityType { get; set; }
        public Guid StructureId { get; set; }
        public int Annee { get; set; }
        public int Value { get; set; }
    }
}
