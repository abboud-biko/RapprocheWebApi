using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Communes
    {
        public Communes()
        {
            CodesPostaux = new HashSet<CodesPostaux>();
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
            Employeurs = new HashSet<Employeurs>();
            EmployeursAvalider = new HashSet<EmployeursAvalider>();
            Offres = new HashSet<Offres>();
            SecteursUrbains = new HashSet<SecteursUrbains>();
        }

        public Guid CommuneId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public Guid WilayaId { get; set; }
        public string Code { get; set; }

        public Wilayas Wilaya { get; set; }
        public ICollection<CodesPostaux> CodesPostaux { get; set; }
        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<SecteursUrbains> SecteursUrbains { get; set; }
    }
}
