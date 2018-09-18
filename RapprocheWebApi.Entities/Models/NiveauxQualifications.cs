using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class NiveauxQualifications
    {
        public NiveauxQualifications()
        {
            CorrespondancesIdqc = new HashSet<CorrespondancesIdqc>();
            Offres = new HashSet<Offres>();
            Profils = new HashSet<Profils>();
            ProfilsAvalider = new HashSet<ProfilsAvalider>();
        }[JsonIgnore]

        public Guid NiveauQualificationId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }[JsonIgnore]
        public int Code { get; set; }[JsonIgnore]

        public ICollection<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }[JsonIgnore]
        public ICollection<Offres> Offres { get; set; }[JsonIgnore]
        public ICollection<Profils> Profils { get; set; }[JsonIgnore]
        public ICollection<ProfilsAvalider> ProfilsAvalider { get; set; }
    }
}
