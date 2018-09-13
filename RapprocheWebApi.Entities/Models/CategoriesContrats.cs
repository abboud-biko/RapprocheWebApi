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

        public Guid CategorieContratId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid DispositifId { get; set; }

        public Dispositifs Dispositif { get; set; }
        public ICollection<TypesContrats> TypesContrats { get; set; }
    }
}
