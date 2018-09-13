using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilAvaliderFicheName
    {
        public Guid ProfilsAvaliderDemandeurId { get; set; }
        public Guid MetiersAcquisFicheNameId { get; set; }
        public bool? ByOnline { get; set; }

        public ProfilsAvalider ProfilsAvaliderDemandeur { get; set; }
    }
}
