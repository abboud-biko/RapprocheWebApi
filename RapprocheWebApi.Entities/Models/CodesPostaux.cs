using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CodesPostaux
    {
        public CodesPostaux()
        {
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
        }

        public Guid CodePostalId { get; set; }
        public string Code { get; set; }
        public Guid CommuneId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }

        public Communes Commune { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
    }
}
