using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SecteursUrbains
    {
        public SecteursUrbains()
        {
            Quartiers = new HashSet<Quartiers>();
        }

        public Guid SecteurUrbainId { get; set; }
        public string IntituleFr { get; set; }
        public string IntituleAr { get; set; }
        public string Code { get; set; }
        public Guid CommuneId { get; set; }

        public Communes Commune { get; set; }
        public ICollection<Quartiers> Quartiers { get; set; }
    }
}
