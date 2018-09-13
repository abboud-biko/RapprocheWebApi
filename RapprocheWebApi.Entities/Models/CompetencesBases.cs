using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CompetencesBases
    {
        public CompetencesBases()
        {
            OffreCompetenceBase = new HashSet<OffreCompetenceBase>();
            ProfilAvaliderCompetenceBase = new HashSet<ProfilAvaliderCompetenceBase>();
            ProfilCompetenceBase = new HashSet<ProfilCompetenceBase>();
        }

        public Guid CompetenceBaseId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid FicheNameId { get; set; }

        public FichesNames FicheName { get; set; }
        public ICollection<OffreCompetenceBase> OffreCompetenceBase { get; set; }
        public ICollection<ProfilAvaliderCompetenceBase> ProfilAvaliderCompetenceBase { get; set; }
        public ICollection<ProfilCompetenceBase> ProfilCompetenceBase { get; set; }
    }
}
