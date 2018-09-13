using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Wilayas
    {
        public Wilayas()
        {
            Communes = new HashSet<Communes>();
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            Structures = new HashSet<Structures>();
        }

        public Guid WilayaId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid PaysId { get; set; }

        public Pays Pays { get; set; }
        public ICollection<Communes> Communes { get; set; }
        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<Structures> Structures { get; set; }
    }
}
