using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class StatutsJuridiques
    {
        public StatutsJuridiques()
        {
            CorrespondanceFormeJuridique = new HashSet<CorrespondanceFormeJuridique>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
        }

        public Guid StatutJuridiqueId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }

        public ICollection<CorrespondanceFormeJuridique> CorrespondanceFormeJuridique { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
    }
}
