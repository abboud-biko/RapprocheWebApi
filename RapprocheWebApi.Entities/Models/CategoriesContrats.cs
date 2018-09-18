using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CategoriesContrats
    {
        public CategoriesContrats()
        {
            TypesContrats = new HashSet<TypesContrats>();
        }
        [JsonIgnore]
        public Guid CategorieContratId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }[JsonIgnore]
        public string Code { get; set; }[JsonIgnore]
        public Guid DispositifId { get; set; }

        public Dispositifs Dispositif { get; set; }[JsonIgnore]
        public ICollection<TypesContrats> TypesContrats { get; set; }
    }
}
