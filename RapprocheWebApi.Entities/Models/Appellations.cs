﻿using Newtonsoft.Json;
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
        [JsonIgnore]
        public Guid AppellationId { get; set; }
        public string IntituleAr { get; set; }[JsonIgnore]
        public Guid FicheNameId { get; set; }
        public string IntituleFr { get; set; }[JsonIgnore]
        public string Code { get; set; }[JsonIgnore]

        public ICollection<DemandeAppellationAlternative> DemandeAppellationAlternative { get; set; }[JsonIgnore]
        public ICollection<Demandes> DemandesFonctionActuelle { get; set; }[JsonIgnore]
        public ICollection<Demandes> DemandesMetierPrincipal { get; set; }[JsonIgnore]
        public ICollection<Experiences> Experiences { get; set; }[JsonIgnore]
        public ICollection<ExperiencesAvalider> ExperiencesAvalider { get; set; }[JsonIgnore]
        public ICollection<Offres> Offres { get; set; }
    }
}
