using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CompetencesSpecifiques
    {
        public CompetencesSpecifiques()
        {
            OffreCompetenceSpecifique = new HashSet<OffreCompetenceSpecifique>();
            ProfilAvaliderCompetenceSpecifique = new HashSet<ProfilAvaliderCompetenceSpecifique>();
            ProfilCompetenceSpecifique = new HashSet<ProfilCompetenceSpecifique>();
        }

        public Guid CompetenceSpecifiqueId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid? ActiviteSpecifiqueId { get; set; }
        public Guid? GroupeActiviteSpecifiqueId { get; set; }

        public ActivitesSpecifiques ActiviteSpecifique { get; set; }
        public GroupesActivitesSpecifiques GroupeActiviteSpecifique { get; set; }
        public ICollection<OffreCompetenceSpecifique> OffreCompetenceSpecifique { get; set; }
        public ICollection<ProfilAvaliderCompetenceSpecifique> ProfilAvaliderCompetenceSpecifique { get; set; }
        public ICollection<ProfilCompetenceSpecifique> ProfilCompetenceSpecifique { get; set; }
    }
}
