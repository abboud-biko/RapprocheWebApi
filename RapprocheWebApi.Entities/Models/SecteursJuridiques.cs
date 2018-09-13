using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SecteursJuridiques
    {
        public SecteursJuridiques()
        {
            CorrespondanceFormeJuridique = new HashSet<CorrespondanceFormeJuridique>();
            Employeurs = new HashSet<Employeurs>();
        }

        public Guid SecteurJuridiqueId { get; set; }
        public string Code { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }

        public ICollection<CorrespondanceFormeJuridique> CorrespondanceFormeJuridique { get; set; }
        public ICollection<Employeurs> Employeurs { get; set; }
    }
}
