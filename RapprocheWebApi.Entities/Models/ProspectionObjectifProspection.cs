using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProspectionObjectifProspection
    {
        public Guid ObjectifsProspectionsObjectifProspectionId { get; set; }
        public Guid ProspectionsProspectionId { get; set; }

        public ObjectifsProspections ObjectifsProspectionsObjectifProspection { get; set; }
        public Prospections ProspectionsProspection { get; set; }
    }
}
