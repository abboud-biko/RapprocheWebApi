using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class CorrespondancesIdqc
    {
        public Guid CorrespondanceId { get; set; }
        public Guid NiveauInstructionId { get; set; }
        public Guid? TypeDiplomeId { get; set; }
        public Guid NiveauQualificationId { get; set; }
        public Guid TypeContratId { get; set; }

        public NiveauxInstructions NiveauInstruction { get; set; }
        public NiveauxQualifications NiveauQualification { get; set; }
        public TypesContrats TypeContrat { get; set; }
        public TypesDiplomes TypeDiplome { get; set; }
    }
}
