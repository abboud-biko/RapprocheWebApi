using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Prospections
    {
        public Prospections()
        {
            ProspectionIntervenant = new HashSet<ProspectionIntervenant>();
            ProspectionObjectifProspection = new HashSet<ProspectionObjectifProspection>();
            Visites = new HashSet<Visites>();
        }

        public Guid ProspectionId { get; set; }
        public string AutreObjectif { get; set; }
        public string Destination { get; set; }
        public DateTime DateProspection { get; set; }
        public string Numero { get; set; }
        public Guid StructureId { get; set; }

        public Structures Structure { get; set; }
        public ICollection<ProspectionIntervenant> ProspectionIntervenant { get; set; }
        public ICollection<ProspectionObjectifProspection> ProspectionObjectifProspection { get; set; }
        public ICollection<Visites> Visites { get; set; }
    }
}
