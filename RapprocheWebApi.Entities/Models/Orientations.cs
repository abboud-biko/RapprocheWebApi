using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Orientations
    {
        public Orientations()
        {
            DetailsResultatsOrientations = new HashSet<DetailsResultatsOrientations>();
            DossiersDaips = new HashSet<DossiersDaips>();
        }

        public Guid OrientationId { get; set; }
        public Guid DemandeId { get; set; }
        public string Numero { get; set; }
        public Guid OffreId { get; set; }
        public string Motif { get; set; }
        public DateTime Date { get; set; }
        public byte Etat { get; set; }
        public string Rapport { get; set; }
        public Guid UserId { get; set; }
        public Guid? VisiteId { get; set; }
        public byte Resultat { get; set; }
        public DateTime? DateRetourReponse { get; set; }
        public bool IsRechercheActive { get; set; }
        public DateTime DateEcheance { get; set; }
        public Guid? ConvocationEnLigneConvocationEnLigneId { get; set; }
        public bool IsDirectPlacement { get; set; }
        public DateTime? DateOrientation { get; set; }
        public string NumeroOld { get; set; }
        public DateTime? DateModificationEnLigne { get; set; }

        public ConvocationsEnLigne ConvocationEnLigneConvocationEnLigne { get; set; }
        public Demandes Demande { get; set; }
        public Offres Offre { get; set; }
        public Intervenants User { get; set; }
        public Visites Visite { get; set; }
        public ICollection<DetailsResultatsOrientations> DetailsResultatsOrientations { get; set; }
        public ICollection<DossiersDaips> DossiersDaips { get; set; }
    }
}
