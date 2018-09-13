using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Langues
    {
        public Langues()
        {
            LanguesMaitrisees = new HashSet<LanguesMaitrisees>();
            LanguesMaitriseesAvalider = new HashSet<LanguesMaitriseesAvalider>();
            OffresLangues = new HashSet<OffresLangues>();
        }

        public Guid LangueId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }

        public ICollection<LanguesMaitrisees> LanguesMaitrisees { get; set; }
        public ICollection<LanguesMaitriseesAvalider> LanguesMaitriseesAvalider { get; set; }
        public ICollection<OffresLangues> OffresLangues { get; set; }
    }
}
