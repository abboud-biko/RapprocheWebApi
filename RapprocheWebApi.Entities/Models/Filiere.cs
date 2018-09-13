using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Filiere
    {
        public Filiere()
        {
            SpecialitesDiplomes = new HashSet<SpecialitesDiplomes>();
        }

        public Guid FiliereId { get; set; }
        public byte Code { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }

        public ICollection<SpecialitesDiplomes> SpecialitesDiplomes { get; set; }
    }
}
