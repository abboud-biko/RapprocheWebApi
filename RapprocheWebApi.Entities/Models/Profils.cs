using System;
using System.Collections.Generic;

namespace RapprocheWebApi.Entities.Models
{
    public partial class Profils
    {
        public Profils()
        {
            Diplomes = new HashSet<Diplomes>();
            Experiences = new HashSet<Experiences>();
            Formations = new HashSet<Formations>();
            LanguesMaitrisees = new HashSet<LanguesMaitrisees>();
            ProfilActiviteBase = new HashSet<ProfilActiviteBase>();
            ProfilActiviteSpecifique = new HashSet<ProfilActiviteSpecifique>();
            ProfilCompetenceBase = new HashSet<ProfilCompetenceBase>();
            ProfilCompetenceSpecifique = new HashSet<ProfilCompetenceSpecifique>();
            ProfilFicheName = new HashSet<ProfilFicheName>();
        }

        public Guid DemandeurId { get; set; }
        public Guid NiveauInstructionId { get; set; }
        public Guid NiveauQualificationId { get; set; }
        public double Experience { get; set; }
        public byte? NiveauMaitriseOutilInformatique { get; set; }
        public byte CategoriePermisConduire { get; set; }
        public bool? ByOnline { get; set; }

        public Demandeurs Demandeur { get; set; }
        public NiveauxInstructions NiveauInstruction { get; set; }
        public NiveauxQualifications NiveauQualification { get; set; }
        public ICollection<Diplomes> Diplomes { get; set; }
        public ICollection<Experiences> Experiences { get; set; }
        public ICollection<Formations> Formations { get; set; }
        public ICollection<LanguesMaitrisees> LanguesMaitrisees { get; set; }
        public ICollection<ProfilActiviteBase> ProfilActiviteBase { get; set; }
        public ICollection<ProfilActiviteSpecifique> ProfilActiviteSpecifique { get; set; }
        public ICollection<ProfilCompetenceBase> ProfilCompetenceBase { get; set; }
        public ICollection<ProfilCompetenceSpecifique> ProfilCompetenceSpecifique { get; set; }
        public ICollection<ProfilFicheName> ProfilFicheName { get; set; }
    }
}
