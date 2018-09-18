using Newtonsoft.Json;
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
        [JsonIgnore]
        public Guid WilayaId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }[JsonIgnore]
        public string Code { get; set; }[JsonIgnore]
        public Guid PaysId { get; set; }[JsonIgnore]

        public Pays Pays { get; set; }[JsonIgnore]
        public ICollection<Communes> Communes { get; set; }[JsonIgnore]
        public ICollection<Demandeurs> Demandeurs { get; set; }[JsonIgnore]
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }[JsonIgnore]
        public ICollection<Employeurs> Employeurs { get; set; }[JsonIgnore]
        public ICollection<EmployeursAvalider> EmployeursAvalider { get; set; }[JsonIgnore]
        public ICollection<Structures> Structures { get; set; }
    }
}
