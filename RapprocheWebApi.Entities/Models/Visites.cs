using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Visites
    {
        public Visites()
        {
            Offres = new HashSet<Offres>();
            Orientations = new HashSet<Orientations>();
        }

        public Guid VisiteId { get; set; }
        public Guid ProspectionId { get; set; }
        public Guid EmployeurId { get; set; }
        public short Etat { get; set; }
        public DateTime DateVisite { get; set; }
        public string Rapport { get; set; }
        public string Numero { get; set; }
        public Guid UserId { get; set; }
        public DateTime? DateReport { get; set; }

        public Employeurs Employeur { get; set; }
        public Prospections Prospection { get; set; }
        public Intervenants User { get; set; }
        public ICollection<Offres> Offres { get; set; }
        public ICollection<Orientations> Orientations { get; set; }
    }
}
