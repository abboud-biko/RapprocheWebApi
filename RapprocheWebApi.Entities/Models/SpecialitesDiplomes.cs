using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class SpecialitesDiplomes
    {
        public SpecialitesDiplomes()
        {
            Diplomes = new HashSet<Diplomes>();
            DiplomesAvalider = new HashSet<DiplomesAvalider>();
            OffreSpecialiteDiplome = new HashSet<OffreSpecialiteDiplome>();
            OptionsDiplomes = new HashSet<OptionsDiplomes>();
        }

        public Guid SpecialiteDiplomeId { get; set; }
        public Guid TypeDiplomeId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }
        public string Code { get; set; }
        public Guid? FiliereId { get; set; }

        public Filiere Filiere { get; set; }
        public TypesDiplomes TypeDiplome { get; set; }
        public ICollection<Diplomes> Diplomes { get; set; }
        public ICollection<DiplomesAvalider> DiplomesAvalider { get; set; }
        public ICollection<OffreSpecialiteDiplome> OffreSpecialiteDiplome { get; set; }
        public ICollection<OptionsDiplomes> OptionsDiplomes { get; set; }
    }
}
