using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SousDomaines
    {
        public SousDomaines()
        {
            FichesNames = new HashSet<FichesNames>();
        }

        public Guid SousDomaineId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public Guid? DomaineId { get; set; }
        public string Code { get; set; }
        public string CodeSousDomaine { get; set; }

        public Domaines Domaine { get; set; }
        public ICollection<FichesNames> FichesNames { get; set; }
    }
}
