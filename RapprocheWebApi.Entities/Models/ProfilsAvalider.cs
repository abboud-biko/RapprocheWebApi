using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class ProfilsAvalider
    {
        public ProfilsAvalider()
        {
            DiplomesAvalider = new HashSet<DiplomesAvalider>();
            ExperiencesAvalider = new HashSet<ExperiencesAvalider>();
            FormationsAvalider = new HashSet<FormationsAvalider>();
            LanguesMaitriseesAvalider = new HashSet<LanguesMaitriseesAvalider>();
            ProfilAvaliderActiviteBase = new HashSet<ProfilAvaliderActiviteBase>();
            ProfilAvaliderActiviteSpecifique = new HashSet<ProfilAvaliderActiviteSpecifique>();
            ProfilAvaliderCompetenceBase = new HashSet<ProfilAvaliderCompetenceBase>();
            ProfilAvaliderCompetenceSpecifique = new HashSet<ProfilAvaliderCompetenceSpecifique>();
            ProfilAvaliderFicheName = new HashSet<ProfilAvaliderFicheName>();
        }

        public Guid DemandeurId { get; set; }
        public Guid NiveauInstructionId { get; set; }
        public Guid NiveauQualificationId { get; set; }
        public double Experience { get; set; }
        public bool IsValid { get; set; }
        public byte? NiveauMaitriseOutilInformatique { get; set; }
        public byte CategoriePermisConduire { get; set; }
        public bool? ByOnline { get; set; }

        public DemandeursAvalider Demandeur { get; set; }
        public NiveauxInstructions NiveauInstruction { get; set; }
        public NiveauxQualifications NiveauQualification { get; set; }
        public ICollection<DiplomesAvalider> DiplomesAvalider { get; set; }
        public ICollection<ExperiencesAvalider> ExperiencesAvalider { get; set; }
        public ICollection<FormationsAvalider> FormationsAvalider { get; set; }
        public ICollection<LanguesMaitriseesAvalider> LanguesMaitriseesAvalider { get; set; }
        public ICollection<ProfilAvaliderActiviteBase> ProfilAvaliderActiviteBase { get; set; }
        public ICollection<ProfilAvaliderActiviteSpecifique> ProfilAvaliderActiviteSpecifique { get; set; }
        public ICollection<ProfilAvaliderCompetenceBase> ProfilAvaliderCompetenceBase { get; set; }
        public ICollection<ProfilAvaliderCompetenceSpecifique> ProfilAvaliderCompetenceSpecifique { get; set; }
        public ICollection<ProfilAvaliderFicheName> ProfilAvaliderFicheName { get; set; }
    }
}
