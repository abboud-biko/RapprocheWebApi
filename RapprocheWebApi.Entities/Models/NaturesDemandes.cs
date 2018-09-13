using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class NaturesDemandes
    {
        public NaturesDemandes()
        {
            Demandes = new HashSet<Demandes>();
            TypeContratNatureDemande = new HashSet<TypeContratNatureDemande>();
        }

        public Guid NatureDemandeId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }

        public ICollection<Demandes> Demandes { get; set; }
        public ICollection<TypeContratNatureDemande> TypeContratNatureDemande { get; set; }
    }
}
