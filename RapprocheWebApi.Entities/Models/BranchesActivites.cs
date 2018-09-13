using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class BranchesActivites
    {
        public BranchesActivites()
        {
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            SousBranchesActivites = new HashSet<SousBranchesActivites>();
        }

        public Guid BrancheActiviteId { get; set; }
        public Guid SecteurActiviteId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid? GroupBrancheActiviteId { get; set; }

        public SecteursActivites SecteurActivite { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<SousBranchesActivites> SousBranchesActivites { get; set; }
    }
}
