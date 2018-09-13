using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Secteurs
    {
        public Secteurs()
        {
            Domaines = new HashSet<Domaines>();
        }

        public Guid SecteurId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public string CodeSecteur { get; set; }

        public ICollection<Domaines> Domaines { get; set; }
    }
}
