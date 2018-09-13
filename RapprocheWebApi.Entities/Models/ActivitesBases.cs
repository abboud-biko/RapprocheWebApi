using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ActivitesBases
    {
        public ActivitesBases()
        {
            OffreActiviteBase = new HashSet<OffreActiviteBase>();
            ProfilActiviteBase = new HashSet<ProfilActiviteBase>();
            ProfilAvaliderActiviteBase = new HashSet<ProfilAvaliderActiviteBase>();
        }

        public Guid ActiviteBaseId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid FicheNameId { get; set; }

        public ICollection<OffreActiviteBase> OffreActiviteBase { get; set; }
        public ICollection<ProfilActiviteBase> ProfilActiviteBase { get; set; }
        public ICollection<ProfilAvaliderActiviteBase> ProfilAvaliderActiviteBase { get; set; }
    }
}
