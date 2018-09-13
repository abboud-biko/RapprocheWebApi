using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Convocations
    {
        public Guid ConvocationId { get; set; }
        public Guid DemandeId { get; set; }
        public string Numero { get; set; }
        public DateTime Date { get; set; }
        public string AutresIndication { get; set; }
        public DateTime? DatePointage { get; set; }
        public string DetailResultat { get; set; }
        public string Cause { get; set; }
        public string Consequence { get; set; }
        public byte Etat { get; set; }
        public Guid? OffreId { get; set; }
        public Guid UserId { get; set; }
        public byte? Resultat { get; set; }
        public DateTime DateExpiration { get; set; }
        public byte NotifierAvant { get; set; }
        public byte ModeConvocation { get; set; }
        public string NumeroOld { get; set; }
        public bool? ByOnline { get; set; }
        public DateTime? DateRetourReponse { get; set; }

        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
        public Intervenants User { get; set; }
    }
}
