using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OrganismesAutresDispositifs
    {
        public OrganismesAutresDispositifs()
        {
            Demandeurs = new HashSet<Demandeurs>();
            DemandeursAvalider = new HashSet<DemandeursAvalider>();
        }

        public Guid OrganismeAutreDispositifId { get; set; }
        public string Code { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }

        public ICollection<Demandeurs> Demandeurs { get; set; }
        public ICollection<DemandeursAvalider> DemandeursAvalider { get; set; }
    }
}
