using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CorrespondanceFormeJuridique
    {
        public Guid CorrespondanceId { get; set; }
        public Guid SecteurActiviteId { get; set; }
        public Guid SecteurJuridiqueId { get; set; }
        public Guid StatutJuridiqueId { get; set; }
        public byte PorteeFormeJuridique { get; set; }

        public SecteursActivites SecteurActivite { get; set; }
        public SecteursJuridiques SecteurJuridique { get; set; }
        public StatutsJuridiques StatutJuridique { get; set; }
    }
}
