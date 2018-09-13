using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class RaisonsSortieDispositif
    {
        public RaisonsSortieDispositif()
        {
            Contrats = new HashSet<Contrats>();
        }

        public Guid RaisonSortieDispositifId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public byte Code { get; set; }

        public ICollection<Contrats> Contrats { get; set; }
    }
}
