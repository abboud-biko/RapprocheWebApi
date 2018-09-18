using Newtonsoft.Json;
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
        [JsonIgnore]
        public Guid CommuneId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }[JsonIgnore]
        public Guid WilayaId { get; set; }[JsonIgnore]
        public string Code { get; set; }

        public Wilayas Wilaya { get; set; }[JsonIgnore]
        public ICollection<CodesPostaux> CodesPostaux { get; set; }[JsonIgnore]
        public ICollection<Demandeurs> Demandeurs { get; set; }[JsonIgnore]
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }[JsonIgnore]
        public ICollection<Employeurs> Employeurs { get; set; }[JsonIgnore]
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }[JsonIgnore]
        public ICollection<Offres> Offres { get; set; }[JsonIgnore]
        public ICollection<SecteursUrbains> SecteursUrbains { get; set; }
    }
}
