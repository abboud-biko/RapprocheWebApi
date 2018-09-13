using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class DossiersDaips
    {
        public DossiersDaips()
        {
            Contrats = new HashSet<Contrats>();
            ContratsFormation = new HashSet<ContratsFormation>();
            EtatsDossier = new HashSet<EtatsDossier>();
        }

        public Guid DossierDaipId { get; set; }
        public string Numero { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateValidation { get; set; }
        public byte Etat { get; set; }
        public Guid? OrientationId { get; set; }
        public string Observation { get; set; }
        public DateTime DateEcheance { get; set; }
        public string MotifRejet { get; set; }

        public Orientations Orientation { get; set; }
        public ICollection<Contrats> Contrats { get; set; }
        public ICollection<ContratsFormation> ContratsFormation { get; set; }
        public ICollection<EtatsDossier> EtatsDossier { get; set; }
    }
}
