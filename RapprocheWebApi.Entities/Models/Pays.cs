using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Pays
    {
        public Pays()
        {
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
            Diplomes = new HashSet<Diplomes>();
            DiplomesAvalider = new HashSet<DiplomesAvalider>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            Wilayas = new HashSet<Wilayas>();
        }

        public Guid PaysId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string NationaliteAr { get; set; }
        public string NationaliteFr { get; set; }
        public string Code { get; set; }

        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
        public ICollection<Diplomes> Diplomes { get; set; }
        public ICollection<DiplomesAvalider> DiplomesAvalider { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<Wilayas> Wilayas { get; set; }
    }
}
