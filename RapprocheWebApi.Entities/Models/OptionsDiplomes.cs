using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class OptionsDiplomes
    {
        public OptionsDiplomes()
        {
            Diplomes = new HashSet<Diplomes>();
            DiplomesAvalider = new HashSet<DiplomesAvalider>();
            OffreOptionDiplome = new HashSet<OffreOptionDiplome>();
        }

        public Guid OptionDiplomeId { get; set; }
        public Guid SpecialiteDiplomeId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }

        public SpecialitesDiplomes SpecialiteDiplome { get; set; }
        public ICollection<Diplomes> Diplomes { get; set; }
        public ICollection<DiplomesAvalider> DiplomesAvalider { get; set; }
        public ICollection<OffreOptionDiplome> OffreOptionDiplome { get; set; }
    }
}
