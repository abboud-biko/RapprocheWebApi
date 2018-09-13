using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class TypesHandicaps
    {
        public TypesHandicaps()
        {
            Handicaps = new HashSet<Handicaps>();
            HandicapsAvalider = new HashSet<HandicapsAvalider>();
        }

        public Guid TypeHandicapId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }

        public ICollection<Handicaps> Handicaps { get; set; }
        public ICollection<HandicapsAvalider> HandicapsAvalider { get; set; }
    }
}
