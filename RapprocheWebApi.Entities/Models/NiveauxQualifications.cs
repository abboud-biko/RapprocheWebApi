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
        }

        public Guid NiveauQualificationId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public int Code { get; set; }

        public ICollection<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<Profils> Profils { get; set; }
        public ICollection<ProfilsAvalider> ProfilsAvalider { get; set; }
    }
}
