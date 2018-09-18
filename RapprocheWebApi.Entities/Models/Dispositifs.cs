using Newtonsoft.Json;
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
        }[JsonIgnore]

        public Guid DispositifId { get; set; }
        public string IntituleFr { get; set; }[JsonIgnore]
        public DateTime DateExpiration { get; set; }
        public string IntituleAr { get; set; }[JsonIgnore]
        public DateTime DateDebutApplication { get; set; }[JsonIgnore]
        public string ObjectifFr { get; set; }[JsonIgnore]
        public string ObjectifAr { get; set; }[JsonIgnore]
        public string Code { get; set; }[JsonIgnore]
        public byte ModeRapprochement { get; set; }[JsonIgnore]

        public ICollection<CategoriesContrats> CategoriesContrats { get; set; }[JsonIgnore]
        public ICollection<Demandes> Demandes { get; set; }
    }
}
