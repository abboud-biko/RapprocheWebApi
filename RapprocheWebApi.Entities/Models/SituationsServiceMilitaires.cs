using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SituationsServiceMilitaires
    {
        public SituationsServiceMilitaires()
        {
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
            Offres = new HashSet<Offres>();
        }

        public Guid SituationServiceMilitaireId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public byte Niveau { get; set; }

        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
        public ICollection<Offres> Offres { get; set; }
    }
}
