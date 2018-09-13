using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SourcesDiplomes
    {
        public SourcesDiplomes()
        {
            TypesDiplomes = new HashSet<TypesDiplomes>();
        }

        public Guid SourceDiplomeId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }

        public ICollection<TypesDiplomes> TypesDiplomes { get; set; }
    }
}
