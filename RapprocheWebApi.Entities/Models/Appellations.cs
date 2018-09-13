using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Appellations
    {
        public Appellations()
        {
            DemandeAppellationAlternative = new HashSet<DemandeAppellationAlternative>();
            DemandesFonctionActuelle = new HashSet<Demandes>();
            DemandesMetierPrincipal = new HashSet<Demandes>();
            Experiences = new HashSet<Experiences>();
            ExperiencesAvalider = new HashSet<ExperiencesAvalider>();
            Offres = new HashSet<Offres>();
        }

        public Guid AppellationId { get; set; }
        public string IntituleAr { get; set; }
        public Guid FicheNameId { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }

        public ICollection<DemandeAppellationAlternative> DemandeAppellationAlternative { get; set; }
        public ICollection<Demandes> DemandesFonctionActuelle { get; set; }
        public ICollection<Demandes> DemandesMetierPrincipal { get; set; }
        public ICollection<Experiences> Experiences { get; set; }
        public ICollection<ExperiencesAvalider> ExperiencesAvalider { get; set; }
        public ICollection<Offres> Offres { get; set; }
    }
}
