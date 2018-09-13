using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ConvocationsEnLigne
    {
        public ConvocationsEnLigne()
        {
            Orientations = new HashSet<Orientations>();
        }

        public Guid ConvocationEnLigneId { get; set; }
        public DateTime DateConvocation { get; set; }
        public DateTime DateCloture { get; set; }
        public byte Resultat { get; set; }
        public Guid DemandeId { get; set; }
        public Guid OffreId { get; set; }
        public byte Etat { get; set; }
        public bool? ByOnline { get; set; }

        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
        public ICollection<Orientations> Orientations { get; set; }
    }
}
