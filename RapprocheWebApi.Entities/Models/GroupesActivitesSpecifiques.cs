using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class GroupesActivitesSpecifiques
    {
        public GroupesActivitesSpecifiques()
        {
            ActivitesSpecifiques = new HashSet<ActivitesSpecifiques>();
            CompetencesSpecifiques = new HashSet<CompetencesSpecifiques>();
        }

        public Guid GroupeActiviteSpecifiqueId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public Guid FicheNameId { get; set; }
        public int? Code { get; set; }

        public ICollection<ActivitesSpecifiques> ActivitesSpecifiques { get; set; }
        public ICollection<CompetencesSpecifiques> CompetencesSpecifiques { get; set; }
    }
}
