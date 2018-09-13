using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class EtatsDossier
    {
        public Guid EtatDossierId { get; set; }
        public short Etat { get; set; }
        public DateTime Date { get; set; }
        public bool IsActuelle { get; set; }
        public Guid DossierDaipId { get; set; }

        public DossiersDaips DossierDaip { get; set; }
    }
}
