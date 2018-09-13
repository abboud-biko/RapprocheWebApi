using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ActivitesSpecifiques
    {
        public ActivitesSpecifiques()
        {
            CompetencesSpecifiques = new HashSet<CompetencesSpecifiques>();
            OffreActiviteSpecifique = new HashSet<OffreActiviteSpecifique>();
            ProfilActiviteSpecifique = new HashSet<ProfilActiviteSpecifique>();
            ProfilAvaliderActiviteSpecifique = new HashSet<ProfilAvaliderActiviteSpecifique>();
        }

        public Guid ActiviteSpecifiqueId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid FicheNameId { get; set; }
        public Guid? GroupeActiviteSpecifiqueId { get; set; }

        public GroupesActivitesSpecifiques GroupeActiviteSpecifique { get; set; }
        public ICollection<CompetencesSpecifiques> CompetencesSpecifiques { get; set; }
        public ICollection<OffreActiviteSpecifique> OffreActiviteSpecifique { get; set; }
        public ICollection<ProfilActiviteSpecifique> ProfilActiviteSpecifique { get; set; }
        public ICollection<ProfilAvaliderActiviteSpecifique> ProfilAvaliderActiviteSpecifique { get; set; }
    }
}
