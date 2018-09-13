using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class TypesDiplomes
    {
        public TypesDiplomes()
        {
            CorrespondancesIdqc = new HashSet<CorrespondancesIdqc>();
            SpecialitesDiplomes = new HashSet<SpecialitesDiplomes>();
        }

        public Guid TypeDiplomeId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid SourceDiplomeId { get; set; }
        public byte DureeEtude { get; set; }

        public SourcesDiplomes SourceDiplome { get; set; }
        public ICollection<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }
        public ICollection<SpecialitesDiplomes> SpecialitesDiplomes { get; set; }
    }
}
