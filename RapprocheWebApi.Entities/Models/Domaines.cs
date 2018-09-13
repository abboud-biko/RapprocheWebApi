using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Domaines
    {
        public Domaines()
        {
            FichesNames = new HashSet<FichesNames>();
            SousDomaines = new HashSet<SousDomaines>();
        }

        public Guid DomaineId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public Guid SecteurId { get; set; }
        public string Code { get; set; }
        public string CodeDomaine { get; set; }

        public Secteurs Secteur { get; set; }
        public ICollection<FichesNames> FichesNames { get; set; }
        public ICollection<SousDomaines> SousDomaines { get; set; }
    }
}
