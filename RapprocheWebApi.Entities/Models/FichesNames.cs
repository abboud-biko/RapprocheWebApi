using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class FichesNames
    {
        public FichesNames()
        {
            CompetencesBases = new HashSet<CompetencesBases>();
            ProfilFicheName = new HashSet<ProfilFicheName>();
        }

        public Guid FicheNameId { get; set; }
        public string Code { get; set; }
        public string IntituleFr { get; set; }
        public string DefinitionAr { get; set; }
        public string ConditionAccesFr { get; set; }
        public string ConditionsExerciceFr { get; set; }
        public string IntituleAr { get; set; }
        public string DefinitionFr { get; set; }
        public string ConditionAccesAr { get; set; }
        public string ConditionsExerciceAr { get; set; }
        public Guid DomaineId { get; set; }
        public Guid? SousDomaineId { get; set; }
        public string CodeFicheName { get; set; }

        public Domaines Domaine { get; set; }
        public SousDomaines SousDomaine { get; set; }
        public ICollection<CompetencesBases> CompetencesBases { get; set; }
        public ICollection<ProfilFicheName> ProfilFicheName { get; set; }
    }
}
