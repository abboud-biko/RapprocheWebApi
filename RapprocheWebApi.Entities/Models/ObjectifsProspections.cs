using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ObjectifsProspections
    {
        public ObjectifsProspections()
        {
            ProspectionObjectifProspection = new HashSet<ProspectionObjectifProspection>();
        }

        public Guid ObjectifProspectionId { get; set; }
        public string IntituleAr { get; set; }
        public string IntituleFr { get; set; }

        public ICollection<ProspectionObjectifProspection> ProspectionObjectifProspection { get; set; }
    }
}
