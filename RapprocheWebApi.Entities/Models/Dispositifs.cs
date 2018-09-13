using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Dispositifs
    {
        public Dispositifs()
        {
            CategoriesContrats = new HashSet<CategoriesContrats>();
            Demandes = new HashSet<Demandes>();
        }

        public Guid DispositifId { get; set; }
        public string IntituleFr { get; set; }
        public DateTime DateExpiration { get; set; }
        public string IntituleAr { get; set; }
        public DateTime DateDebutApplication { get; set; }
        public string ObjectifFr { get; set; }
        public string ObjectifAr { get; set; }
        public string Code { get; set; }
        public byte ModeRapprochement { get; set; }

        public ICollection<CategoriesContrats> CategoriesContrats { get; set; }
        public ICollection<Demandes> Demandes { get; set; }
    }
}
