using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilFicheName
    {
        public Guid ProfilsDemandeurId { get; set; }
        public Guid MetiersAcquisFicheNameId { get; set; }
        public bool? ByOnline { get; set; }

        public FichesNames MetiersAcquisFicheName { get; set; }
        public Profils ProfilsDemandeur { get; set; }
    }
}
