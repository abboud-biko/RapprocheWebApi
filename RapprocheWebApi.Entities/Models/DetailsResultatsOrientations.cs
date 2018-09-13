using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class DetailsResultatsOrientations
    {
        public Guid DetailResultatOrientationId { get; set; }
        public Guid OrientationId { get; set; }
        public byte Resultat { get; set; }
        public byte Etat { get; set; }
        public DateTime Date { get; set; }
        public bool IsActuel { get; set; }
        public bool? ByOnline { get; set; }
        public byte? Source { get; set; }

        public Orientations Orientation { get; set; }
    }
}
