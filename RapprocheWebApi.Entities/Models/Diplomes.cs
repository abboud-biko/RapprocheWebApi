using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Diplomes
    {
        public Guid DiplomeObtenuId { get; set; }
        public Guid SpecialiteDiplomeId { get; set; }
        public short AnneeObtention { get; set; }
        public string Etablissement { get; set; }
        public Guid PaysId { get; set; }
        public Guid DemandeurId { get; set; }
        public Guid? OptionDiplomeId { get; set; }
        public bool? ByOnline { get; set; }

        public Profils Demandeur { get; set; }
        public OptionsDiplomes OptionDiplome { get; set; }
        public Pays Pays { get; set; }
        public SpecialitesDiplomes SpecialiteDiplome { get; set; }
    }
}
