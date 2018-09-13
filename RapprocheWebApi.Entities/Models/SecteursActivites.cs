using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SecteursActivites
    {
        public SecteursActivites()
        {
            BranchesActivites = new HashSet<BranchesActivites>();
            CorrespondanceFormeJuridique = new HashSet<CorrespondanceFormeJuridique>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            TypesContrats = new HashSet<TypesContrats>();
        }

        public Guid SecteurActiviteId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public bool AccepteRechercheActive { get; set; }
        public string Code { get; set; }

        public ICollection<BranchesActivites> BranchesActivites { get; set; }
        public ICollection<CorrespondanceFormeJuridique> CorrespondanceFormeJuridique { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<TypesContrats> TypesContrats { get; set; }
    }
}
