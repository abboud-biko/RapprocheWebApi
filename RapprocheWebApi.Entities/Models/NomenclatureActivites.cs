using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class NomenclatureActivites
    {
        public Guid NomenclatureActiviteId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid? EmployeurEmployeurId { get; set; }

        public Employeurs EmployeurEmployeur { get; set; }
    }
}
