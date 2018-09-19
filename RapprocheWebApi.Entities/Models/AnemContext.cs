using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace RapprocheWebApi.Entities.Models
{
    public partial class AnemContext : DbContext
    {
        public AnemContext()
        {
        }

        public AnemContext(DbContextOptions<AnemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivitesBases> ActivitesBases { get; set; }
        public virtual DbSet<ActivitesSpecifiques> ActivitesSpecifiques { get; set; }
        public virtual DbSet<Appellations> Appellations { get; set; }
        public virtual DbSet<BranchesActivites> BranchesActivites { get; set; }
        public virtual DbSet<CategoriesContrats> CategoriesContrats { get; set; }
        public virtual DbSet<CodesPostaux> CodesPostaux { get; set; }
        public virtual DbSet<Communes> Communes { get; set; }
        public virtual DbSet<CompetencesBases> CompetencesBases { get; set; }
        public virtual DbSet<CompetencesSpecifiques> CompetencesSpecifiques { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Contrats> Contrats { get; set; }
        public virtual DbSet<ContratsFormation> ContratsFormation { get; set; }
        public virtual DbSet<Convocations> Convocations { get; set; }
        public virtual DbSet<ConvocationsEnLigne> ConvocationsEnLigne { get; set; }
        public virtual DbSet<CorrespondanceFormeJuridique> CorrespondanceFormeJuridique { get; set; }
        public virtual DbSet<CorrespondancesIdqc> CorrespondancesIdqc { get; set; }
        public virtual DbSet<DemandeAppellationAlternative> DemandeAppellationAlternative { get; set; }
        public virtual DbSet<Demandes> Demandes { get; set; }
        public virtual DbSet<Demandeurs> Demandeurs { get; set; }
        public virtual DbSet<DemandeursAvalider> DemandeursAvalider { get; set; }
        public virtual DbSet<DemandeursStructures> DemandeursStructures { get; set; }
        public virtual DbSet<DetailsResultatsOrientations> DetailsResultatsOrientations { get; set; }
        public virtual DbSet<Diplomes> Diplomes { get; set; }
        public virtual DbSet<DiplomesAvalider> DiplomesAvalider { get; set; }
        public virtual DbSet<Dispositifs> Dispositifs { get; set; }
        public virtual DbSet<Domaines> Domaines { get; set; }
        public virtual DbSet<DossiersDaips> DossiersDaips { get; set; }
        public virtual DbSet<EmployeurDocuments> EmployeurDocuments { get; set; }
        public virtual DbSet<EmployeurDocumentsAvalider> EmployeurDocumentsAvalider { get; set; }
        public virtual DbSet<Employeurs> Employeurs { get; set; }
        public virtual DbSet<EmployeursAvalider> EmployeursAvalider { get; set; }
        public virtual DbSet<EmployeurTypeDoc> EmployeurTypeDoc { get; set; }
        public virtual DbSet<EnvironnementsTravails> EnvironnementsTravails { get; set; }
        public virtual DbSet<EtatsContrat> EtatsContrat { get; set; }
        public virtual DbSet<EtatsDemandes> EtatsDemandes { get; set; }
        public virtual DbSet<EtatsDossier> EtatsDossier { get; set; }
        public virtual DbSet<Experiences> Experiences { get; set; }
        public virtual DbSet<ExperiencesAvalider> ExperiencesAvalider { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<FichesNames> FichesNames { get; set; }
        public virtual DbSet<Filiere> Filiere { get; set; }
        public virtual DbSet<Formations> Formations { get; set; }
        public virtual DbSet<FormationsAvalider> FormationsAvalider { get; set; }
        public virtual DbSet<GroupesActivitesSpecifiques> GroupesActivitesSpecifiques { get; set; }
        public virtual DbSet<Handicaps> Handicaps { get; set; }
        public virtual DbSet<HandicapsAvalider> HandicapsAvalider { get; set; }
        public virtual DbSet<Intervenants> Intervenants { get; set; }
        public virtual DbSet<IntervenantsStructures> IntervenantsStructures { get; set; }
        public virtual DbSet<Langues> Langues { get; set; }
        public virtual DbSet<LanguesMaitrisees> LanguesMaitrisees { get; set; }
        public virtual DbSet<LanguesMaitriseesAvalider> LanguesMaitriseesAvalider { get; set; }
        public virtual DbSet<NaturesDemandes> NaturesDemandes { get; set; }
        public virtual DbSet<NiveauxInstructions> NiveauxInstructions { get; set; }
        public virtual DbSet<NiveauxQualifications> NiveauxQualifications { get; set; }
        public virtual DbSet<NomenclatureActivites> NomenclatureActivites { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<ObjectifsProspections> ObjectifsProspections { get; set; }
        public virtual DbSet<OffreActiviteBase> OffreActiviteBase { get; set; }
        public virtual DbSet<OffreActiviteSpecifique> OffreActiviteSpecifique { get; set; }
        public virtual DbSet<OffreCompetenceBase> OffreCompetenceBase { get; set; }
        public virtual DbSet<OffreCompetenceSpecifique> OffreCompetenceSpecifique { get; set; }
        public virtual DbSet<OffreOptionDiplome> OffreOptionDiplome { get; set; }
        public virtual DbSet<Offres> Offres { get; set; }
        public virtual DbSet<OffresLangues> OffresLangues { get; set; }
        public virtual DbSet<OffreSpecialiteDiplome> OffreSpecialiteDiplome { get; set; }
        public virtual DbSet<OffreStructureCompensation> OffreStructureCompensation { get; set; }
        public virtual DbSet<OnlineNotifications> OnlineNotifications { get; set; }
        public virtual DbSet<OptionsDiplomes> OptionsDiplomes { get; set; }
        public virtual DbSet<OrganismesAutresDispositifs> OrganismesAutresDispositifs { get; set; }
        public virtual DbSet<Orientations> Orientations { get; set; }
        public virtual DbSet<Parametres> Parametres { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Postulations> Postulations { get; set; }
        public virtual DbSet<ProfilActiviteBase> ProfilActiviteBase { get; set; }
        public virtual DbSet<ProfilActiviteSpecifique> ProfilActiviteSpecifique { get; set; }
        public virtual DbSet<ProfilAvaliderActiviteBase> ProfilAvaliderActiviteBase { get; set; }
        public virtual DbSet<ProfilAvaliderActiviteSpecifique> ProfilAvaliderActiviteSpecifique { get; set; }
        public virtual DbSet<ProfilAvaliderCompetenceBase> ProfilAvaliderCompetenceBase { get; set; }
        public virtual DbSet<ProfilAvaliderCompetenceSpecifique> ProfilAvaliderCompetenceSpecifique { get; set; }
        public virtual DbSet<ProfilAvaliderFicheName> ProfilAvaliderFicheName { get; set; }
        public virtual DbSet<ProfilCompetenceBase> ProfilCompetenceBase { get; set; }
        public virtual DbSet<ProfilCompetenceSpecifique> ProfilCompetenceSpecifique { get; set; }
        public virtual DbSet<ProfilFicheName> ProfilFicheName { get; set; }
        public virtual DbSet<Profils> Profils { get; set; }
        public virtual DbSet<ProfilsAvalider> ProfilsAvalider { get; set; }
        public virtual DbSet<PropositionsReferentiel> PropositionsReferentiel { get; set; }
        public virtual DbSet<ProspectionIntervenant> ProspectionIntervenant { get; set; }
        public virtual DbSet<ProspectionObjectifProspection> ProspectionObjectifProspection { get; set; }
        public virtual DbSet<Prospections> Prospections { get; set; }
        public virtual DbSet<QrCode> QrCode { get; set; }
        public virtual DbSet<Quartiers> Quartiers { get; set; }
        public virtual DbSet<RaisonsSortieDispositif> RaisonsSortieDispositif { get; set; }
        public virtual DbSet<Rapprochements> Rapprochements { get; set; }
        public virtual DbSet<Secteurs> Secteurs { get; set; }
        public virtual DbSet<SecteursActivites> SecteursActivites { get; set; }
        public virtual DbSet<SecteursJuridiques> SecteursJuridiques { get; set; }
        public virtual DbSet<SecteursUrbains> SecteursUrbains { get; set; }
        public virtual DbSet<Sequences> Sequences { get; set; }
        public virtual DbSet<SituationsServiceMilitaires> SituationsServiceMilitaires { get; set; }
        public virtual DbSet<SourcesDiplomes> SourcesDiplomes { get; set; }
        public virtual DbSet<SousBranchesActivites> SousBranchesActivites { get; set; }
        public virtual DbSet<SousDomaines> SousDomaines { get; set; }
        public virtual DbSet<SpecialitesDiplomes> SpecialitesDiplomes { get; set; }
        public virtual DbSet<StatutsJuridiques> StatutsJuridiques { get; set; }
        public virtual DbSet<Structures> Structures { get; set; }
        public virtual DbSet<Traces> Traces { get; set; }
        public virtual DbSet<TypeContratNatureDemande> TypeContratNatureDemande { get; set; }
        public virtual DbSet<TypeDocument> TypeDocument { get; set; }
        public virtual DbSet<TypesContratReconduction> TypesContratReconduction { get; set; }
        public virtual DbSet<TypesContrats> TypesContrats { get; set; }
        public virtual DbSet<TypesDiplomes> TypesDiplomes { get; set; }
        public virtual DbSet<TypesHandicaps> TypesHandicaps { get; set; }
        public virtual DbSet<TypesPiecesIdentites> TypesPiecesIdentites { get; set; }
        public virtual DbSet<Visites> Visites { get; set; }
        public virtual DbSet<Wilayas> Wilayas { get; set; }

        // Unable to generate entity type for table 'dbo.BranchesActivitesGroupe'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DocumentImprime'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("User ID=AnemUser;Password=AnemUser@@;Server=10.16.100.183;Database=Anem;Trusted_Connection=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivitesBases>(entity =>
            {
                entity.HasKey(e => e.ActiviteBaseId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_FicheNameActiviteBase");

                entity.Property(e => e.ActiviteBaseId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ActivitesSpecifiques>(entity =>
            {
                entity.HasKey(e => e.ActiviteSpecifiqueId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_FicheNameActiviteSpecifique");

                entity.HasIndex(e => e.GroupeActiviteSpecifiqueId)
                    .HasName("IX_FK_GroupeActiviteSpecifiqueActiviteSpecifique");

                entity.Property(e => e.ActiviteSpecifiqueId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.GroupeActiviteSpecifique)
                    .WithMany(p => p.ActivitesSpecifiques)
                    .HasForeignKey(d => d.GroupeActiviteSpecifiqueId)
                    .HasConstraintName("FK_GroupeActiviteSpecifiqueActiviteSpecifique");
            });

            modelBuilder.Entity<Appellations>(entity =>
            {
                entity.HasKey(e => e.AppellationId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_AppellationFicheName");

                entity.Property(e => e.AppellationId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BranchesActivites>(entity =>
            {
                entity.HasKey(e => e.BrancheActiviteId);

                entity.HasIndex(e => e.SecteurActiviteId)
                    .HasName("IX_FK_BrancheActiviteSecteurActivite");

                entity.Property(e => e.BrancheActiviteId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.GroupBrancheActiviteId).HasColumnName("GroupBrancheActiviteID");

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.SecteurActivite)
                    .WithMany(p => p.BranchesActivites)
                    .HasForeignKey(d => d.SecteurActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrancheActiviteSecteurActivite");
            });

            modelBuilder.Entity<CategoriesContrats>(entity =>
            {
                entity.HasKey(e => e.CategorieContratId);

                entity.HasIndex(e => e.DispositifId)
                    .HasName("IX_FK_DispositifCategorieContrat");

                entity.Property(e => e.CategorieContratId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Dispositif)
                    .WithMany(p => p.CategoriesContrats)
                    .HasForeignKey(d => d.DispositifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DispositifCategorieContrat");
            });

            modelBuilder.Entity<CodesPostaux>(entity =>
            {
                entity.HasKey(e => e.CodePostalId);

                entity.HasIndex(e => e.CommuneId)
                    .HasName("IX_FK_CodePostalCommune");

                entity.Property(e => e.CodePostalId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.CodesPostaux)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CodePostalCommune");
            });

            modelBuilder.Entity<Communes>(entity =>
            {
                entity.HasKey(e => e.CommuneId);

                entity.HasIndex(e => e.WilayaId)
                    .HasName("IX_FK_WilayaCommune");

                entity.Property(e => e.CommuneId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Wilaya)
                    .WithMany(p => p.Communes)
                    .HasForeignKey(d => d.WilayaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WilayaCommune");
            });

            modelBuilder.Entity<CompetencesBases>(entity =>
            {
                entity.HasKey(e => e.CompetenceBaseId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_FicheNameCompetenceBase");

                entity.Property(e => e.CompetenceBaseId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.FicheName)
                    .WithMany(p => p.CompetencesBases)
                    .HasForeignKey(d => d.FicheNameId)
                    .HasConstraintName("FK_FicheNameCompetenceBase");
            });

            modelBuilder.Entity<CompetencesSpecifiques>(entity =>
            {
                entity.HasKey(e => e.CompetenceSpecifiqueId);

                entity.HasIndex(e => e.ActiviteSpecifiqueId)
                    .HasName("IX_FK_ActiviteSpecifiqueCompetenceSpecifique");

                entity.HasIndex(e => e.GroupeActiviteSpecifiqueId)
                    .HasName("IX_FK_GroupeActiviteSpecifiqueCompetenceSpecifique");

                entity.Property(e => e.CompetenceSpecifiqueId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ActiviteSpecifique)
                    .WithMany(p => p.CompetencesSpecifiques)
                    .HasForeignKey(d => d.ActiviteSpecifiqueId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ActiviteSpecifiqueCompetenceSpecifique");

                entity.HasOne(d => d.GroupeActiviteSpecifique)
                    .WithMany(p => p.CompetencesSpecifiques)
                    .HasForeignKey(d => d.GroupeActiviteSpecifiqueId)
                    .HasConstraintName("FK_GroupeActiviteSpecifiqueCompetenceSpecifique");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.HasIndex(e => e.EmployeurId)
                    .HasName("IX_FK_ContactEmployeur");

                entity.Property(e => e.ContactId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FonctionInterlocuteur)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Interlocuteur)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Employeur)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.EmployeurId)
                    .HasConstraintName("FK_ContactEmployeur");
            });

            modelBuilder.Entity<Contrats>(entity =>
            {
                entity.HasKey(e => e.ContratId);

                entity.HasIndex(e => e.ContratInitialContratId)
                    .HasName("IX_FK_ContratContrat");

                entity.HasIndex(e => e.DossierDaipDossierDaipId)
                    .HasName("IX_FK_DossierDaipContrat");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Contrats")
                    .IsUnique();

                entity.HasIndex(e => e.RaisonSortieDispositifId)
                    .HasName("IX_FK_RaisonSortieDispositifContrat");

                entity.HasIndex(e => e.TypeContratId)
                    .HasName("IX_FK_TypeContratContrat");

                entity.Property(e => e.ContratId).ValueGeneratedNever();

                entity.Property(e => e.CauseResiliation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ContratInitialContratId).HasColumnName("ContratInitial_ContratId");

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.DateResiliation).HasColumnType("datetime");

                entity.Property(e => e.DossierDaipDossierDaipId).HasColumnName("DossierDaip_DossierDaipId");

                entity.Property(e => e.MontantAide).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Salaire).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ContratInitialContrat)
                    .WithMany(p => p.InverseContratInitialContrat)
                    .HasForeignKey(d => d.ContratInitialContratId)
                    .HasConstraintName("FK_ContratContrat");

                entity.HasOne(d => d.DossierDaipDossierDaip)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.DossierDaipDossierDaipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DossierDaipContrat");

                entity.HasOne(d => d.RaisonSortieDispositif)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.RaisonSortieDispositifId)
                    .HasConstraintName("FK_RaisonSortieDispositifContrat");

                entity.HasOne(d => d.TypeContrat)
                    .WithMany(p => p.Contrats)
                    .HasForeignKey(d => d.TypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratContrat");
            });

            modelBuilder.Entity<ContratsFormation>(entity =>
            {
                entity.HasKey(e => e.ContratFormationId);

                entity.HasIndex(e => e.ContratId)
                    .HasName("IX_FK_ContratContratFormation");

                entity.HasIndex(e => e.DossierDaipDossierDaipId)
                    .HasName("IX_FK_DossierDaipContratFormation");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_ContratsFormation")
                    .IsUnique();

                entity.Property(e => e.ContratFormationId).ValueGeneratedNever();

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Domaine).HasMaxLength(200);

                entity.Property(e => e.DossierDaipDossierDaipId).HasColumnName("DossierDaip_DossierDaipId");

                entity.Property(e => e.MontantAide).IsRequired();

                entity.Property(e => e.MontantFormation).IsRequired();

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.OrganismeFormateur).HasMaxLength(200);

                entity.Property(e => e.PourcentageAide).IsRequired();

                entity.HasOne(d => d.Contrat)
                    .WithMany(p => p.ContratsFormation)
                    .HasForeignKey(d => d.ContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContratContratFormation");

                entity.HasOne(d => d.DossierDaipDossierDaip)
                    .WithMany(p => p.ContratsFormation)
                    .HasForeignKey(d => d.DossierDaipDossierDaipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DossierDaipContratFormation");
            });

            modelBuilder.Entity<Convocations>(entity =>
            {
                entity.HasKey(e => e.ConvocationId);

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_ConvocationDemande");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Convocations")
                    .IsUnique();

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_ConvocationOffre");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantConvocation");

                entity.Property(e => e.ConvocationId).ValueGeneratedNever();

                entity.Property(e => e.AutresIndication).HasMaxLength(200);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Cause)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Consequence)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DatePointage).HasColumnType("datetime");

                entity.Property(e => e.DateRetourReponse).HasColumnType("datetime");

                entity.Property(e => e.DetailResultat).HasMaxLength(500);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NumeroOld)
                    .HasColumnName("numero_old")
                    .HasMaxLength(32);

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.Convocations)
                    .HasForeignKey(d => d.DemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConvocationDemande");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.Convocations)
                    .HasForeignKey(d => d.OffreId)
                    .HasConstraintName("FK_ConvocationOffre");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Convocations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantConvocation");
            });

            modelBuilder.Entity<ConvocationsEnLigne>(entity =>
            {
                entity.HasKey(e => e.ConvocationEnLigneId);

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_DemandeConvocationEnLigne");

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_OffreConvocationEnLigne");

                entity.Property(e => e.ConvocationEnLigneId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateCloture).HasColumnType("datetime");

                entity.Property(e => e.DateConvocation).HasColumnType("datetime");

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.ConvocationsEnLigne)
                    .HasForeignKey(d => d.DemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeConvocationEnLigne");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.ConvocationsEnLigne)
                    .HasForeignKey(d => d.OffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreConvocationEnLigne");
            });

            modelBuilder.Entity<CorrespondanceFormeJuridique>(entity =>
            {
                entity.HasKey(e => e.CorrespondanceId);

                entity.HasIndex(e => new { e.SecteurActiviteId, e.SecteurJuridiqueId, e.StatutJuridiqueId })
                    .HasName("IX_CorrespondanceFormeJuridique")
                    .IsUnique();

                entity.Property(e => e.CorrespondanceId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.SecteurActivite)
                    .WithMany(p => p.CorrespondanceFormeJuridique)
                    .HasForeignKey(d => d.SecteurActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorrespondanceFormeJuridique_SecteursActivites");

                entity.HasOne(d => d.SecteurJuridique)
                    .WithMany(p => p.CorrespondanceFormeJuridique)
                    .HasForeignKey(d => d.SecteurJuridiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorrespondanceFormeJuridique_SecteursJuridiques");

                entity.HasOne(d => d.StatutJuridique)
                    .WithMany(p => p.CorrespondanceFormeJuridique)
                    .HasForeignKey(d => d.StatutJuridiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CorrespondanceFormeJuridique_StatutsJuridiques");
            });

            modelBuilder.Entity<CorrespondancesIdqc>(entity =>
            {
                entity.HasKey(e => e.CorrespondanceId);

                entity.ToTable("CorrespondancesIDQC");

                entity.HasIndex(e => e.NiveauInstructionId)
                    .HasName("IX_FK_NiveauInstructionCorrespondanceIDQC");

                entity.HasIndex(e => e.NiveauQualificationId)
                    .HasName("IX_FK_NiveauQualificationCorrespondanceIDQC");

                entity.HasIndex(e => e.TypeContratId)
                    .HasName("IX_FK_TypeContratCorrespondanceIDQC");

                entity.HasIndex(e => e.TypeDiplomeId)
                    .HasName("IX_FK_TypeDiplomeCorrespondanceIDQC");

                entity.Property(e => e.CorrespondanceId).ValueGeneratedNever();

                entity.HasOne(d => d.NiveauInstruction)
                    .WithMany(p => p.CorrespondancesIdqc)
                    .HasForeignKey(d => d.NiveauInstructionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NiveauInstructionCorrespondanceIDQC");

                entity.HasOne(d => d.NiveauQualification)
                    .WithMany(p => p.CorrespondancesIdqc)
                    .HasForeignKey(d => d.NiveauQualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NiveauQualificationCorrespondanceIDQC");

                entity.HasOne(d => d.TypeContrat)
                    .WithMany(p => p.CorrespondancesIdqc)
                    .HasForeignKey(d => d.TypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratCorrespondanceIDQC");

                entity.HasOne(d => d.TypeDiplome)
                    .WithMany(p => p.CorrespondancesIdqc)
                    .HasForeignKey(d => d.TypeDiplomeId)
                    .HasConstraintName("FK_TypeDiplomeCorrespondanceIDQC");
            });

            modelBuilder.Entity<DemandeAppellationAlternative>(entity =>
            {
                entity.HasKey(e => new { e.DemandesDemandeId, e.MetiersAlternatifsAppellationId });

                entity.HasIndex(e => e.DemandesDemandeId)
                    .HasName("IX_FK_DemandeAppellationAlternative_Demande");

                entity.HasIndex(e => e.MetiersAlternatifsAppellationId)
                    .HasName("IX_FK_DemandeAppellationAlternative_Appellation");

                entity.Property(e => e.DemandesDemandeId).HasColumnName("Demandes_DemandeId");

                entity.Property(e => e.MetiersAlternatifsAppellationId).HasColumnName("MetiersAlternatifs_AppellationId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DemandesDemande)
                    .WithMany(p => p.DemandeAppellationAlternative)
                    .HasForeignKey(d => d.DemandesDemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeAppellationAlternative_Demande");

                entity.HasOne(d => d.MetiersAlternatifsAppellation)
                    .WithMany(p => p.DemandeAppellationAlternative)
                    .HasForeignKey(d => d.MetiersAlternatifsAppellationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeAppellationAlternative_Appellation");
            });

            modelBuilder.Entity<Demandes>(entity =>
            {
                entity.HasKey(e => e.DemandeId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_DemandeDemandeur");

                entity.HasIndex(e => e.DispositifId)
                    .HasName("IX_FK_DispositifDemande");

                entity.HasIndex(e => e.FonctionActuelleId)
                    .HasName("IX_FK_DemandeAppellationFonctionActuelle");

                entity.HasIndex(e => e.MetierPrincipalId)
                    .HasName("IX_FK_DemandeAppellation");

                entity.HasIndex(e => e.NatureDemandeId)
                    .HasName("IX_FK_NatureDemandeDemande");

                entity.HasIndex(e => e.Numero)
                    .HasName("Numero");

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_DemandeStructure");

                entity.HasIndex(e => e.TypeContratId)
                    .HasName("IX_FK_TypeContactDemande");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantDemande");

                entity.HasIndex(e => new { e.StructureId, e.Etat })
                    .HasName("XI_DemandeStructureEtat");

                entity.HasIndex(e => new { e.DemandeurId, e.Date, e.StructureId, e.Etat })
                    .HasName("XI_DemandeStructureEtatDate");

                entity.Property(e => e.DemandeId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CauseCloture).HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateAnnulationPrevue).HasColumnType("datetime");

                entity.Property(e => e.DateCloture).HasColumnType("datetime");

                entity.Property(e => e.DateCloturePrevue).HasColumnType("datetime");

                entity.Property(e => e.DateMiseEnInstancePrevue).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SalaireSouhaite).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeDemandeur");

                entity.HasOne(d => d.Dispositif)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.DispositifId)
                    .HasConstraintName("FK_DispositifDemande");

                entity.HasOne(d => d.FonctionActuelle)
                    .WithMany(p => p.DemandesFonctionActuelle)
                    .HasForeignKey(d => d.FonctionActuelleId)
                    .HasConstraintName("FK_DemandeAppellationFonctionActuelle");

                entity.HasOne(d => d.MetierPrincipal)
                    .WithMany(p => p.DemandesMetierPrincipal)
                    .HasForeignKey(d => d.MetierPrincipalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeAppellation");

                entity.HasOne(d => d.NatureDemande)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.NatureDemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NatureDemandeDemande");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeStructure");

                entity.HasOne(d => d.TypeContrat)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.TypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContactDemande");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Demandes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantDemande");
            });

            modelBuilder.Entity<Demandeurs>(entity =>
            {
                entity.HasKey(e => e.DemandeurId);

                entity.HasIndex(e => e.CommuneNaissanceId)
                    .HasName("IX_FK_CommuneDemandeur");

                entity.HasIndex(e => e.DateNaissance)
                    .HasName("IX_DataNaissance");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_Demandeurs_Mail");

                entity.HasIndex(e => e.EnregistrementCadreAutreDispositifId)
                    .HasName("IX_FK_OrganismeAutreDispositifDemandeur");

                entity.HasIndex(e => e.IntervenantUserId)
                    .HasName("IX_FK_IntervenantDemandeur");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Demandeurs")
                    .IsUnique();

                entity.HasIndex(e => e.PaysNaissanceId)
                    .HasName("IX_FK_PaysDemandeur");

                entity.HasIndex(e => e.QuartierId)
                    .HasName("IX_FK_QuartierDemandeur");

                entity.HasIndex(e => e.SituationServiceMilitaireId)
                    .HasName("IX_FK_DemandeurSituationServiceMilitaire");

                entity.HasIndex(e => e.TypePieceIdentiteId)
                    .HasName("IX_FK_DemandeurTypePieceIdentite");

                entity.HasIndex(e => e.WilayaNaissanceId)
                    .HasName("IX_FK_WilayaDemandeur");

                entity.HasIndex(e => new { e.NomAr, e.NomFr })
                    .HasName("IX_Nom");

                entity.HasIndex(e => new { e.PrenomAr, e.PrenomFr })
                    .HasName("IX_Prenom");

                entity.HasIndex(e => new { e.DateNaissance, e.Mobile, e.Gendre, e.Handicap, e.DateInscription, e.Civilite, e.DemandeurId, e.Numero, e.NomAr, e.NomFr, e.PrenomFr, e.PrenomAr })
                    .HasName("IX_Demandeurs1");

                entity.HasIndex(e => new { e.DateNaissance, e.Mobile, e.Gendre, e.Handicap, e.DateInscription, e.Civilite, e.QuartierId, e.PrenomFr, e.DemandeurId, e.PrenomAr, e.Numero, e.NomAr, e.NomFr })
                    .HasName("XI_Demandeurs_SeArcH");

                entity.Property(e => e.DemandeurId).ValueGeneratedNever();

                entity.Property(e => e.AdresseAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AdresseFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnName("Date_enregistrement")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateInscription).HasColumnType("datetime");

                entity.Property(e => e.DateNaissance).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.IntervenantUserId).HasColumnName("Intervenant_UserId");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.NomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomMere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombrePersonnesAcharge).HasColumnName("NombrePersonnesACharge");

                entity.Property(e => e.Nss).HasMaxLength(15);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.NumeroActeNaissance)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.NumeroPieceIdentite).HasMaxLength(18);

                entity.Property(e => e.PieceIdentitieDelivreeLe).HasColumnType("datetime");

                entity.Property(e => e.PieceIdentitieDelivreePar)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrenomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomMere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomPere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.HasOne(d => d.CommuneNaissance)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.CommuneNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommuneDemandeur");

                entity.HasOne(d => d.EnregistrementCadreAutreDispositif)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.EnregistrementCadreAutreDispositifId)
                    .HasConstraintName("FK_OrganismeAutreDispositifDemandeur");

                entity.HasOne(d => d.IntervenantUser)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.IntervenantUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantDemandeur");

                entity.HasOne(d => d.PaysNaissance)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.PaysNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaysDemandeur");

                entity.HasOne(d => d.Quartier)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.QuartierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuartierDemandeur");

                entity.HasOne(d => d.SituationServiceMilitaire)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.SituationServiceMilitaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurSituationServiceMilitaire");

                entity.HasOne(d => d.TypePieceIdentite)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.TypePieceIdentiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurTypePieceIdentite");

                entity.HasOne(d => d.WilayaNaissance)
                    .WithMany(p => p.Demandeurs)
                    .HasForeignKey(d => d.WilayaNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WilayaDemandeur");
            });

            modelBuilder.Entity<DemandeursAvalider>(entity =>
            {
                entity.HasKey(e => e.DemandeurId);

                entity.ToTable("DemandeursAValider");

                entity.HasIndex(e => e.CommuneNaissanceId)
                    .HasName("IX_FK_CommuneNaissanceDemandeurAValider");

                entity.HasIndex(e => e.EnregistrementCadreAutreDispositifId)
                    .HasName("IX_FK_OrganismeAutreDispositifDemandeurAValider");

                entity.HasIndex(e => e.IntervenantUserId)
                    .HasName("IX_FK_IntervenantDemandeurAValider");

                entity.HasIndex(e => e.PaysNaissanceId)
                    .HasName("IX_FK_PaysNaissanceDemandeurAValider");

                entity.HasIndex(e => e.QuartierId)
                    .HasName("IX_FK_QuartierDemandeurAValider");

                entity.HasIndex(e => e.SituationServiceMilitaireId)
                    .HasName("IX_FK_SituationServiceMilitaireDemandeurAValider");

                entity.HasIndex(e => e.TypePieceIdentiteId)
                    .HasName("IX_FK_TypePieceIdentiteDemandeurAValider");

                entity.HasIndex(e => e.WilayaNaissanceId)
                    .HasName("IX_FK_WilayaNaissanceDemandeurAValider");

                entity.Property(e => e.DemandeurId).ValueGeneratedNever();

                entity.Property(e => e.AdresseAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AdresseFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnName("Date_enregistrement")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateInscription).HasColumnType("datetime");

                entity.Property(e => e.DateNaissance).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.IntervenantUserId).HasColumnName("Intervenant_UserId");

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.NomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomMere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombrePersonnesAcharge).HasColumnName("NombrePersonnesACharge");

                entity.Property(e => e.Nss).HasMaxLength(15);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.NumeroActeNaissance)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.NumeroPieceIdentite).HasMaxLength(18);

                entity.Property(e => e.PieceIdentitieDelivreeLe).HasColumnType("datetime");

                entity.Property(e => e.PieceIdentitieDelivreePar)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrenomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomMere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomPere)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.HasOne(d => d.CommuneNaissance)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.CommuneNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommuneNaissanceDemandeurAValider");

                entity.HasOne(d => d.EnregistrementCadreAutreDispositif)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.EnregistrementCadreAutreDispositifId)
                    .HasConstraintName("FK_OrganismeAutreDispositifDemandeurAValider");

                entity.HasOne(d => d.IntervenantUser)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.IntervenantUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantDemandeurAValider");

                entity.HasOne(d => d.PaysNaissance)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.PaysNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaysNaissanceDemandeurAValider");

                entity.HasOne(d => d.Quartier)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.QuartierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuartierDemandeurAValider");

                entity.HasOne(d => d.SituationServiceMilitaire)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.SituationServiceMilitaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SituationServiceMilitaireDemandeurAValider");

                entity.HasOne(d => d.TypePieceIdentite)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.TypePieceIdentiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypePieceIdentiteDemandeurAValider");

                entity.HasOne(d => d.WilayaNaissance)
                    .WithMany(p => p.DemandeursAvalider)
                    .HasForeignKey(d => d.WilayaNaissanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WilayaNaissanceDemandeurAValider");
            });

            modelBuilder.Entity<DemandeursStructures>(entity =>
            {
                entity.HasKey(e => e.DemandeurStructureId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_DemandeurStructureDemandeur");

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_DemandeurStructureStructure");

                entity.HasIndex(e => new { e.DemandeurId, e.Actuelle })
                    .HasName("IsActuelleIndex");

                entity.HasIndex(e => new { e.DemandeurId, e.Actuelle, e.DemandeurStructureId, e.StructureId })
                    .HasName("_dta_index_DemandeursStructures_7_661577395__K2_K4_K1_K3");

                entity.Property(e => e.DemandeurStructureId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.DemandeursStructures)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurStructureDemandeur");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.DemandeursStructures)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurStructureStructure");
            });

            modelBuilder.Entity<DetailsResultatsOrientations>(entity =>
            {
                entity.HasKey(e => e.DetailResultatOrientationId);

                entity.HasIndex(e => e.OrientationId)
                    .HasName("IX_FK_OrientationResultatOrientation");

                entity.Property(e => e.DetailResultatOrientationId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Orientation)
                    .WithMany(p => p.DetailsResultatsOrientations)
                    .HasForeignKey(d => d.OrientationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrientationResultatOrientation");
            });

            modelBuilder.Entity<Diplomes>(entity =>
            {
                entity.HasKey(e => e.DiplomeObtenuId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilDiplomeObtenu");

                entity.HasIndex(e => e.OptionDiplomeId)
                    .HasName("IX_FK_OptionDiplomeDiplomeObtenu");

                entity.HasIndex(e => e.PaysId)
                    .HasName("IX_FK_DiplomeObtenuPays");

                entity.HasIndex(e => e.SpecialiteDiplomeId)
                    .HasName("IX_FK_DiplomeSpecialiteDiplome");

                entity.Property(e => e.DiplomeObtenuId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Etablissement)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.Diplomes)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilDiplomeObtenu");

                entity.HasOne(d => d.OptionDiplome)
                    .WithMany(p => p.Diplomes)
                    .HasForeignKey(d => d.OptionDiplomeId)
                    .HasConstraintName("FK_OptionDiplomeDiplomeObtenu");

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.Diplomes)
                    .HasForeignKey(d => d.PaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiplomeObtenuPays");

                entity.HasOne(d => d.SpecialiteDiplome)
                    .WithMany(p => p.Diplomes)
                    .HasForeignKey(d => d.SpecialiteDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiplomeSpecialiteDiplome");
            });

            modelBuilder.Entity<DiplomesAvalider>(entity =>
            {
                entity.HasKey(e => e.DiplomeObtenuId);

                entity.ToTable("DiplomesAValider");

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilAValiderDiplomeAValider");

                entity.HasIndex(e => e.OptionDiplomeId)
                    .HasName("IX_FK_OptionDiplomeDiplomeAValider");

                entity.HasIndex(e => e.PaysId)
                    .HasName("IX_FK_PaysDiplomeAValider");

                entity.HasIndex(e => e.SpecialiteDiplomeId)
                    .HasName("IX_FK_SpecialiteDiplomeDiplomeAValider");

                entity.Property(e => e.DiplomeObtenuId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Etablissement)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.DiplomesAvalider)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderDiplomeAValider");

                entity.HasOne(d => d.OptionDiplome)
                    .WithMany(p => p.DiplomesAvalider)
                    .HasForeignKey(d => d.OptionDiplomeId)
                    .HasConstraintName("FK_OptionDiplomeDiplomeAValider");

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.DiplomesAvalider)
                    .HasForeignKey(d => d.PaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaysDiplomeAValider");

                entity.HasOne(d => d.SpecialiteDiplome)
                    .WithMany(p => p.DiplomesAvalider)
                    .HasForeignKey(d => d.SpecialiteDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpecialiteDiplomeDiplomeAValider");
            });

            modelBuilder.Entity<Dispositifs>(entity =>
            {
                entity.HasKey(e => e.DispositifId);

                entity.Property(e => e.DispositifId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.DateDebutApplication).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ObjectifAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ObjectifFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Domaines>(entity =>
            {
                entity.HasKey(e => e.DomaineId);

                entity.HasIndex(e => e.SecteurId)
                    .HasName("IX_FK_SecteurDomaine");

                entity.Property(e => e.DomaineId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodeDomaine)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Secteur)
                    .WithMany(p => p.Domaines)
                    .HasForeignKey(d => d.SecteurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecteurDomaine");
            });

            modelBuilder.Entity<DossiersDaips>(entity =>
            {
                entity.HasKey(e => e.DossierDaipId);

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_DossiersDaips")
                    .IsUnique();

                entity.HasIndex(e => e.OrientationId)
                    .HasName("IX_FK_OrientationDossierDaip");

                entity.Property(e => e.DossierDaipId).ValueGeneratedNever();

                entity.Property(e => e.DateCreation).HasColumnType("datetime");

                entity.Property(e => e.DateEcheance).HasColumnType("datetime");

                entity.Property(e => e.DateValidation).HasColumnType("datetime");

                entity.Property(e => e.MotifRejet).HasMaxLength(2000);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Observation).HasMaxLength(2000);

                entity.HasOne(d => d.Orientation)
                    .WithMany(p => p.DossiersDaips)
                    .HasForeignKey(d => d.OrientationId)
                    .HasConstraintName("FK_OrientationDossierDaip");
            });

            modelBuilder.Entity<EmployeurDocuments>(entity =>
            {
                entity.HasKey(e => e.EmployeurDocId);

                entity.HasIndex(e => new { e.DocumentId, e.Numero })
                    .HasName("UK_Document_Employeur")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentId, e.Numero, e.EmployeurId, e.Actuelle })
                    .HasName("INDX_emp-typedoc");

                entity.Property(e => e.EmployeurDocId)
                    .HasColumnName("EmployeurDocID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateEnregistrement).HasColumnType("datetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.EmployeurDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurDocuments_EmployeurTypeDoc");

                entity.HasOne(d => d.Employeur)
                    .WithMany(p => p.EmployeurDocuments)
                    .HasForeignKey(d => d.EmployeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurDocuments_Employeurs");
            });

            modelBuilder.Entity<EmployeurDocumentsAvalider>(entity =>
            {
                entity.HasKey(e => e.EmployeurDocId);

                entity.ToTable("EmployeurDocumentsAValider");

                entity.Property(e => e.EmployeurDocId)
                    .HasColumnName("EmployeurDocID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateEnregistrement).HasColumnType("datetime");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.EmployeurDocumentsAvalider)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurDocumentsAValider_EmployeurTypeDoc");

                entity.HasOne(d => d.Employeur)
                    .WithMany(p => p.EmployeurDocumentsAvalider)
                    .HasForeignKey(d => d.EmployeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurDocumentsAValider_EmployeursAValider");
            });

            modelBuilder.Entity<Employeurs>(entity =>
            {
                entity.HasKey(e => e.EmployeurId);

                entity.HasIndex(e => e.BrancheActiviteId)
                    .HasName("IX_FK_EmployeurBrancheActivite");

                entity.HasIndex(e => e.CodePostalId)
                    .HasName("IX_FK_CodePostalEmployeur");

                entity.HasIndex(e => e.CommuneId)
                    .HasName("IX_FK_EmployeurCommune");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_Employeurs_Mail");

                entity.HasIndex(e => e.EntrepriseMereId)
                    .HasName("IX_FK_EmployeurEmployeur");

                entity.HasIndex(e => e.IntervenantUserId)
                    .HasName("IX_FK_IntervenantEmployeur");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Employeurs")
                    .IsUnique();

                entity.HasIndex(e => e.PaysId)
                    .HasName("IX_FK_EmployeurPays");

                entity.HasIndex(e => e.SecteurActiviteId)
                    .HasName("IX_FK_EmployeurSecteurActivite");

                entity.HasIndex(e => e.SecteurJuridiqueId)
                    .HasName("IX_FK_SecteurJuridiqueEmployeur");

                entity.HasIndex(e => e.StatutJuridiqueId)
                    .HasName("IX_FK_EmployeurStatutJuridique");

                entity.HasIndex(e => e.WilayaId)
                    .HasName("IX_FK_EmployeurWilaya");

                entity.Property(e => e.EmployeurId).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AutresIndications).HasMaxLength(100);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CauseDesactivation).HasMaxLength(500);

                entity.Property(e => e.CodeAgenceCnrss)
                    .HasColumnName("CodeAgenceCNRSS")
                    .HasMaxLength(5);

                entity.Property(e => e.CompteBancaire)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateDebutActivite).HasColumnType("datetime");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateInscription).HasColumnType("datetime");

                entity.Property(e => e.DateInscriptionCnas)
                    .HasColumnName("DateInscriptionCNAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.DenomnationCommerciale).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.Fonction)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IntervenantUserId).HasColumnName("Intervenant_UserId");

                entity.Property(e => e.IsGeneratedByAnem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF")
                    .HasMaxLength(15);

                entity.Property(e => e.NombreEmployesCta).HasColumnName("NombreEmployesCTA");

                entity.Property(e => e.NombreEmployesDaipenCours).HasColumnName("NombreEmployesDAIPEnCours");

                entity.Property(e => e.NombreEmployesNonDaip).HasColumnName("NombreEmployesNonDAIP");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NumeroOld)
                    .HasColumnName("numero_old")
                    .HasMaxLength(16);

                entity.Property(e => e.NumeroRc).HasMaxLength(20);

                entity.Property(e => e.RaisonSociale).HasMaxLength(200);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rib)
                    .IsRequired()
                    .HasColumnName("RIB")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.Property(e => e.TypeCreationEmployeur).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeEmployeur).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BrancheActivite)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.BrancheActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurBrancheActivite");

                entity.HasOne(d => d.CodePostal)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.CodePostalId)
                    .HasConstraintName("FK_CodePostalEmployeur");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurCommune");

                entity.HasOne(d => d.EntrepriseMere)
                    .WithMany(p => p.InverseEntrepriseMere)
                    .HasForeignKey(d => d.EntrepriseMereId)
                    .HasConstraintName("FK_EmployeurEmployeur");

                entity.HasOne(d => d.IntervenantUser)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.IntervenantUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantEmployeur");

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.PaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurPays");

                entity.HasOne(d => d.SecteurActivite)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.SecteurActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurSecteurActivite");

                entity.HasOne(d => d.SecteurJuridique)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.SecteurJuridiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecteurJuridiqueEmployeur");

                entity.HasOne(d => d.StatutJuridique)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.StatutJuridiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurStatutJuridique");

                entity.HasOne(d => d.Wilaya)
                    .WithMany(p => p.Employeurs)
                    .HasForeignKey(d => d.WilayaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurWilaya");
            });

            modelBuilder.Entity<EmployeursAvalider>(entity =>
            {
                entity.HasKey(e => e.EmployeurId);

                entity.ToTable("EmployeursAValider");

                entity.HasIndex(e => e.BrancheActiviteId)
                    .HasName("IX_FK_BrancheActiviteEmployeurAValider");

                entity.HasIndex(e => e.CodePostalId)
                    .HasName("IX_FK_CodePostalEmployeurAValider");

                entity.HasIndex(e => e.CommuneId)
                    .HasName("IX_FK_CommuneEmployeurAValider");

                entity.HasIndex(e => e.IntervenantUserId)
                    .HasName("IX_FK_IntervenantEmployeurAValider");

                entity.HasIndex(e => e.PaysId)
                    .HasName("IX_FK_PaysEmployeurAValider");

                entity.HasIndex(e => e.SecteurActiviteId)
                    .HasName("IX_FK_SecteurActiviteEmployeurAValider");

                entity.HasIndex(e => e.StatutJuridiqueId)
                    .HasName("IX_FK_StatutJuridiqueEmployeurAValider");

                entity.HasIndex(e => e.WilayaId)
                    .HasName("IX_FK_WilayaEmployeurAValider");

                entity.Property(e => e.EmployeurId).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AutresIndications).HasMaxLength(100);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CauseDesactivation).HasMaxLength(500);

                entity.Property(e => e.CodeAgenceCnrss)
                    .HasColumnName("CodeAgenceCNRSS")
                    .HasMaxLength(5);

                entity.Property(e => e.CompteBancaire)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateDebutActivite).HasColumnType("datetime");

                entity.Property(e => e.DateEnregistrement)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateInscription).HasColumnType("datetime");

                entity.Property(e => e.DateInscriptionCnas)
                    .HasColumnName("DateInscriptionCNAS")
                    .HasColumnType("datetime");

                entity.Property(e => e.DenomnationCommerciale).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.Fonction)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IntervenantUserId).HasColumnName("Intervenant_UserId");

                entity.Property(e => e.IsGeneratedByAnem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile).HasMaxLength(100);

                entity.Property(e => e.Nif)
                    .IsRequired()
                    .HasColumnName("NIF")
                    .HasMaxLength(15);

                entity.Property(e => e.NombreEmployesCta).HasColumnName("NombreEmployesCTA");

                entity.Property(e => e.NombreEmployesDaipenCours).HasColumnName("NombreEmployesDAIPEnCours");

                entity.Property(e => e.NombreEmployesNonDaip).HasColumnName("NombreEmployesNonDAIP");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NumeroRc).HasMaxLength(20);

                entity.Property(e => e.RaisonSociale).HasMaxLength(200);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Rib)
                    .IsRequired()
                    .HasColumnName("RIB")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(100);

                entity.Property(e => e.TypeCreationEmployeur).HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeEmployeur).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BrancheActivite)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.BrancheActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrancheActiviteEmployeurAValider");

                entity.HasOne(d => d.CodePostal)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.CodePostalId)
                    .HasConstraintName("FK_CodePostalEmployeurAValider");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommuneEmployeurAValider");

                entity.HasOne(d => d.IntervenantUser)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.IntervenantUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantEmployeurAValider");

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.PaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaysEmployeurAValider");

                entity.HasOne(d => d.SecteurActivite)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.SecteurActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecteurActiviteEmployeurAValider");

                entity.HasOne(d => d.StatutJuridique)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.StatutJuridiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatutJuridiqueEmployeurAValider");

                entity.HasOne(d => d.Wilaya)
                    .WithMany(p => p.EmployeursAvalider)
                    .HasForeignKey(d => d.WilayaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WilayaEmployeurAValider");
            });

            modelBuilder.Entity<EmployeurTypeDoc>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId)
                    .HasColumnName("DocumentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasColumnName("IntituleAR")
                    .HasMaxLength(50);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasColumnName("IntituleFR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnvironnementsTravails>(entity =>
            {
                entity.HasKey(e => e.EnvironnementTravailId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_FicheNameEnvironnementTravail");

                entity.Property(e => e.EnvironnementTravailId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<EtatsContrat>(entity =>
            {
                entity.HasKey(e => e.EtatContratId);

                entity.HasIndex(e => e.ContratId)
                    .HasName("IX_FK_ContratEtatContrat");

                entity.Property(e => e.EtatContratId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Contrat)
                    .WithMany(p => p.EtatsContrat)
                    .HasForeignKey(d => d.ContratId)
                    .HasConstraintName("FK_ContratEtatContrat");
            });

            modelBuilder.Entity<EtatsDemandes>(entity =>
            {
                entity.HasKey(e => e.EtatDemandeId);

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_EtatDemandeDemande");

                entity.Property(e => e.EtatDemandeId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.EtatsDemandes)
                    .HasForeignKey(d => d.DemandeId)
                    .HasConstraintName("FK_EtatDemandeDemande");
            });

            modelBuilder.Entity<EtatsDossier>(entity =>
            {
                entity.HasKey(e => e.EtatDossierId);

                entity.HasIndex(e => e.DossierDaipId)
                    .HasName("IX_FK_DossierDaipEtatDossier");

                entity.Property(e => e.EtatDossierId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.DossierDaip)
                    .WithMany(p => p.EtatsDossier)
                    .HasForeignKey(d => d.DossierDaipId)
                    .HasConstraintName("FK_DossierDaipEtatDossier");
            });

            modelBuilder.Entity<Experiences>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilExperience");

                entity.HasIndex(e => e.PosteOccupeId)
                    .HasName("IX_FK_ExperienceAppellation");

                entity.Property(e => e.ExperienceId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Organisme)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilExperience");

                entity.HasOne(d => d.PosteOccupe)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.PosteOccupeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExperienceAppellation");
            });

            modelBuilder.Entity<ExperiencesAvalider>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.ToTable("ExperiencesAValider");

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilAValiderExperienceAValider");

                entity.HasIndex(e => e.PosteOccupeId)
                    .HasName("IX_FK_AppellationExperienceAValider");

                entity.Property(e => e.ExperienceId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Organisme)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.ExperiencesAvalider)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderExperienceAValider");

                entity.HasOne(d => d.PosteOccupe)
                    .WithMany(p => p.ExperiencesAvalider)
                    .HasForeignKey(d => d.PosteOccupeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppellationExperienceAValider");
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.Property(e => e.FeedbackId).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(28);

                entity.Property(e => e.Feed).IsRequired();

                entity.Property(e => e.Identity)
                    .HasMaxLength(28)
                    .HasDefaultValueSql("('Anonymous')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(28);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FichesNames>(entity =>
            {
                entity.HasKey(e => e.FicheNameId);

                entity.HasIndex(e => e.DomaineId)
                    .HasName("IX_FK_DomaineFicheName");

                entity.HasIndex(e => e.SousDomaineId)
                    .HasName("IX_FK_SousDomaineFicheName");

                entity.Property(e => e.FicheNameId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodeFicheName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ConditionAccesAr)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ConditionAccesFr)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ConditionsExerciceAr)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ConditionsExerciceFr)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DefinitionAr)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DefinitionFr)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Domaine)
                    .WithMany(p => p.FichesNames)
                    .HasForeignKey(d => d.DomaineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomaineFicheName");

                entity.HasOne(d => d.SousDomaine)
                    .WithMany(p => p.FichesNames)
                    .HasForeignKey(d => d.SousDomaineId)
                    .HasConstraintName("FK_SousDomaineFicheName");
            });

            modelBuilder.Entity<Filiere>(entity =>
            {
                entity.Property(e => e.FiliereId)
                    .HasColumnName("FiliereID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .HasColumnName("IntituleAR")
                    .HasMaxLength(100);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasColumnName("IntituleFR")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Formations>(entity =>
            {
                entity.HasKey(e => e.FormationId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilFormation");

                entity.Property(e => e.FormationId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Etablissement)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.Formations)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilFormation");
            });

            modelBuilder.Entity<FormationsAvalider>(entity =>
            {
                entity.HasKey(e => e.FormationId);

                entity.ToTable("FormationsAValider");

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilAValiderFormationAValider");

                entity.Property(e => e.FormationId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DateDebut).HasColumnType("datetime");

                entity.Property(e => e.DateFin).HasColumnType("datetime");

                entity.Property(e => e.Etablissement)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Intitule)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.FormationsAvalider)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderFormationAValider");
            });

            modelBuilder.Entity<GroupesActivitesSpecifiques>(entity =>
            {
                entity.HasKey(e => e.GroupeActiviteSpecifiqueId);

                entity.HasIndex(e => e.FicheNameId)
                    .HasName("IX_FK_FicheNameGroupeActiviteSpecifique");

                entity.Property(e => e.GroupeActiviteSpecifiqueId).ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Handicaps>(entity =>
            {
                entity.HasKey(e => e.HandicapId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_HandicapDemandeur");

                entity.HasIndex(e => e.TypeHandicapId)
                    .HasName("IX_FK_HandicapTypeHandicap");

                entity.Property(e => e.HandicapId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Taux)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.Handicaps)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HandicapDemandeur");

                entity.HasOne(d => d.TypeHandicap)
                    .WithMany(p => p.Handicaps)
                    .HasForeignKey(d => d.TypeHandicapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HandicapTypeHandicap");
            });

            modelBuilder.Entity<HandicapsAvalider>(entity =>
            {
                entity.HasKey(e => e.HandicapId);

                entity.ToTable("HandicapsAValider");

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_DemandeurAValiderHandicapAValider");

                entity.HasIndex(e => e.TypeHandicapId)
                    .HasName("IX_FK_TypeHandicapHandicapAValider");

                entity.Property(e => e.HandicapId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Taux)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.HandicapsAvalider)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurAValiderHandicapAValider");

                entity.HasOne(d => d.TypeHandicap)
                    .WithMany(p => p.HandicapsAvalider)
                    .HasForeignKey(d => d.TypeHandicapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeHandicapHandicapAValider");
            });

            modelBuilder.Entity<Intervenants>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.NomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomAr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrenomFr)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);
            });

            modelBuilder.Entity<IntervenantsStructures>(entity =>
            {
                entity.HasKey(e => e.IntervenantStructureId);

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructureIntervenantStructure");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantIntervenantStructure");

                entity.Property(e => e.IntervenantStructureId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.IntervenantsStructures)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureIntervenantStructure");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.IntervenantsStructures)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_IntervenantIntervenantStructure");
            });

            modelBuilder.Entity<Langues>(entity =>
            {
                entity.HasKey(e => e.LangueId);

                entity.Property(e => e.LangueId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<LanguesMaitrisees>(entity =>
            {
                entity.HasKey(e => e.LangueMaitriseeId);

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilLangueMaitrisee");

                entity.HasIndex(e => e.LangueId)
                    .HasName("IX_FK_LangueMaitriseeLangue");

                entity.Property(e => e.LangueMaitriseeId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.LanguesMaitrisees)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilLangueMaitrisee");

                entity.HasOne(d => d.Langue)
                    .WithMany(p => p.LanguesMaitrisees)
                    .HasForeignKey(d => d.LangueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LangueMaitriseeLangue");
            });

            modelBuilder.Entity<LanguesMaitriseesAvalider>(entity =>
            {
                entity.HasKey(e => e.LangueMaitriseeId);

                entity.ToTable("LanguesMaitriseesAValider");

                entity.HasIndex(e => e.DemandeurId)
                    .HasName("IX_FK_ProfilAValiderLangueMaitriseeAValider");

                entity.HasIndex(e => e.LangueId)
                    .HasName("IX_FK_LangueLangueMaitriseeAValider");

                entity.Property(e => e.LangueMaitriseeId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Demandeur)
                    .WithMany(p => p.LanguesMaitriseesAvalider)
                    .HasForeignKey(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderLangueMaitriseeAValider");

                entity.HasOne(d => d.Langue)
                    .WithMany(p => p.LanguesMaitriseesAvalider)
                    .HasForeignKey(d => d.LangueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LangueLangueMaitriseeAValider");
            });

            modelBuilder.Entity<NaturesDemandes>(entity =>
            {
                entity.HasKey(e => e.NatureDemandeId);

                entity.Property(e => e.NatureDemandeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NiveauxInstructions>(entity =>
            {
                entity.HasKey(e => e.NiveauInstructionId);

                entity.Property(e => e.NiveauInstructionId).ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NiveauxQualifications>(entity =>
            {
                entity.HasKey(e => e.NiveauQualificationId);

                entity.Property(e => e.NiveauQualificationId).ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<NomenclatureActivites>(entity =>
            {
                entity.HasKey(e => e.NomenclatureActiviteId);

                entity.HasIndex(e => e.EmployeurEmployeurId)
                    .HasName("IX_FK_EmployeurNomenclatureActivite");

                entity.Property(e => e.NomenclatureActiviteId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeurEmployeurId).HasColumnName("Employeur_EmployeurId");

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.EmployeurEmployeur)
                    .WithMany(p => p.NomenclatureActivites)
                    .HasForeignKey(d => d.EmployeurEmployeurId)
                    .HasConstraintName("FK_EmployeurNomenclatureActivite");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructureNotification");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantNotification");

                entity.Property(e => e.NotificationId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Titre)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.StructureId)
                    .HasConstraintName("FK_StructureNotification");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_IntervenantNotification");
            });

            modelBuilder.Entity<ObjectifsProspections>(entity =>
            {
                entity.HasKey(e => e.ObjectifProspectionId);

                entity.Property(e => e.ObjectifProspectionId).ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OffreActiviteBase>(entity =>
            {
                entity.HasKey(e => new { e.ActivitesBasesActiviteBaseId, e.OffresOffreId });

                entity.HasIndex(e => e.ActivitesBasesActiviteBaseId)
                    .HasName("IX_FK_OffreActiviteBase_ActivitesBase");

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreActiviteBase_Offres");

                entity.Property(e => e.ActivitesBasesActiviteBaseId).HasColumnName("ActivitesBases_ActiviteBaseId");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesBasesActiviteBase)
                    .WithMany(p => p.OffreActiviteBase)
                    .HasForeignKey(d => d.ActivitesBasesActiviteBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreActiviteBase_ActivitesBase");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreActiviteBase)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreActiviteBase_Offres");
            });

            modelBuilder.Entity<OffreActiviteSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.ActivitesSpecifiquesActiviteSpecifiqueId, e.OffresOffreId });

                entity.HasIndex(e => e.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .HasName("IX_FK_OffreActiviteSpecifique_ActivitesSpecifiques");

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreActiviteSpecifique_Offres");

                entity.Property(e => e.ActivitesSpecifiquesActiviteSpecifiqueId).HasColumnName("ActivitesSpecifiques_ActiviteSpecifiqueId");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesSpecifiquesActiviteSpecifique)
                    .WithMany(p => p.OffreActiviteSpecifique)
                    .HasForeignKey(d => d.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreActiviteSpecifique_ActivitesSpecifiques");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreActiviteSpecifique)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreActiviteSpecifique_Offres");
            });

            modelBuilder.Entity<OffreCompetenceBase>(entity =>
            {
                entity.HasKey(e => new { e.CompetencesBasesCompetenceBaseId, e.OffresOffreId });

                entity.HasIndex(e => e.CompetencesBasesCompetenceBaseId)
                    .HasName("IX_FK_OffreCompetenceBase_CompetencesBase");

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreCompetenceBase_Offres");

                entity.Property(e => e.CompetencesBasesCompetenceBaseId).HasColumnName("CompetencesBases_CompetenceBaseId");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesBasesCompetenceBase)
                    .WithMany(p => p.OffreCompetenceBase)
                    .HasForeignKey(d => d.CompetencesBasesCompetenceBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreCompetenceBase_CompetencesBase");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreCompetenceBase)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreCompetenceBase_Offres");
            });

            modelBuilder.Entity<OffreCompetenceSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.CompetencesSpecifiquesCompetenceSpecifiqueId, e.OffresOffreId });

                entity.HasIndex(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .HasName("IX_FK_OffreCompetenceSpecifique_CompetencesSpecifiques");

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreCompetenceSpecifique_Offres");

                entity.Property(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId).HasColumnName("CompetencesSpecifiques_CompetenceSpecifiqueId");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesSpecifiquesCompetenceSpecifique)
                    .WithMany(p => p.OffreCompetenceSpecifique)
                    .HasForeignKey(d => d.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreCompetenceSpecifique_CompetencesSpecifiques");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreCompetenceSpecifique)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreCompetenceSpecifique_Offres");
            });

            modelBuilder.Entity<OffreOptionDiplome>(entity =>
            {
                entity.HasKey(e => new { e.OffresOffreId, e.OptionsDiplomesOptionDiplomeId });

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreOptionDiplome_Offres");

                entity.HasIndex(e => e.OptionsDiplomesOptionDiplomeId)
                    .HasName("IX_FK_OffreOptionDiplome_OptionsDiplomes");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.OptionsDiplomesOptionDiplomeId).HasColumnName("OptionsDiplomes_OptionDiplomeId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreOptionDiplome)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreOptionDiplome_Offres");

                entity.HasOne(d => d.OptionsDiplomesOptionDiplome)
                    .WithMany(p => p.OffreOptionDiplome)
                    .HasForeignKey(d => d.OptionsDiplomesOptionDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreOptionDiplome_OptionsDiplomes");
            });

            modelBuilder.Entity<Offres>(entity =>
            {
                entity.HasKey(e => e.OffreId);

                entity.HasIndex(e => e.CommuneId)
                    .HasName("IX_FK_OffreCommune");

                entity.HasIndex(e => e.EmployeurId)
                    .HasName("IX_FK_EmployeurOffre");

                entity.HasIndex(e => e.MetierOffertId)
                    .HasName("IX_FK_OffreAppellation");

                entity.HasIndex(e => e.NiveauInstructionId)
                    .HasName("IX_FK_OffreNiveauInstruction");

                entity.HasIndex(e => e.NiveauQualificationId)
                    .HasName("IX_FK_OffreNiveauQualification");

                entity.HasIndex(e => e.Numero)
                    .HasName("XI_OffreNumero");

                entity.HasIndex(e => e.OffreOriginaleId)
                    .HasName("IX_FK_OffreOffreBis");

                entity.HasIndex(e => e.SituationServiceMilitaireId)
                    .HasName("IX_FK_SituationServiceMilitaireOffre");

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructureOffre");

                entity.HasIndex(e => e.TypeContratId)
                    .HasName("IX_FK_TypeContratOffre");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantOffre");

                entity.HasIndex(e => e.VisiteId)
                    .HasName("IX_FK_VisiteOffre");

                entity.HasIndex(e => new { e.DateInscription, e.OffreId, e.StructureId })
                    .HasName("_dta_index_Offres_5_324196205__K14_K1_K23");

                entity.Property(e => e.OffreId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CanShared).HasDefaultValueSql("((1))");

                entity.Property(e => e.CauseCloture).HasMaxLength(200);

                entity.Property(e => e.CauseDesactivation).HasMaxLength(200);

                entity.Property(e => e.DateAnnulation).HasColumnType("datetime");

                entity.Property(e => e.DateCloture).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateInscription).HasColumnType("datetime");

                entity.Property(e => e.DateShared).HasColumnType("datetime");

                entity.Property(e => e.DateSuivi).HasColumnType("datetime");

                entity.Property(e => e.IsModifieeEnLigne)
                    .IsRequired()
                    .HasDefaultValueSql(@"CREATE DEFAULT [dbo].[DF_IsModifierEnligne]
    AS '0';


");

                entity.Property(e => e.IsValide).HasDefaultValueSql("('1')");

                entity.Property(e => e.LieuTravail)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.NumeroOld)
                    .HasColumnName("numero_old")
                    .HasMaxLength(16);

                entity.Property(e => e.SalaireOffert).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreCommune");

                entity.HasOne(d => d.Employeur)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.EmployeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeurOffre");

                entity.HasOne(d => d.MetierOffert)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.MetierOffertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreAppellation");

                entity.HasOne(d => d.NiveauInstruction)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.NiveauInstructionId)
                    .HasConstraintName("FK_OffreNiveauInstruction");

                entity.HasOne(d => d.NiveauQualification)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.NiveauQualificationId)
                    .HasConstraintName("FK_OffreNiveauQualification");

                entity.HasOne(d => d.OffreOriginale)
                    .WithMany(p => p.InverseOffreOriginale)
                    .HasForeignKey(d => d.OffreOriginaleId)
                    .HasConstraintName("FK_OffreOffreBis");

                entity.HasOne(d => d.SituationServiceMilitaire)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.SituationServiceMilitaireId)
                    .HasConstraintName("FK_SituationServiceMilitaireOffre");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureOffre");

                entity.HasOne(d => d.TypeContrat)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.TypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratOffre");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantOffre");

                entity.HasOne(d => d.Visite)
                    .WithMany(p => p.Offres)
                    .HasForeignKey(d => d.VisiteId)
                    .HasConstraintName("FK_VisiteOffre");
            });

            modelBuilder.Entity<OffresLangues>(entity =>
            {
                entity.HasKey(e => e.OffreLangueId);

                entity.HasIndex(e => e.LangueId)
                    .HasName("IX_FK_LangueOffreLangue");

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_OffreOffreLangue");

                entity.Property(e => e.OffreLangueId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Langue)
                    .WithMany(p => p.OffresLangues)
                    .HasForeignKey(d => d.LangueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LangueOffreLangue");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.OffresLangues)
                    .HasForeignKey(d => d.OffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreOffreLangue");
            });

            modelBuilder.Entity<OffreSpecialiteDiplome>(entity =>
            {
                entity.HasKey(e => new { e.OffresOffreId, e.SpecialitesDiplomesSpecialiteDiplomeId });

                entity.HasIndex(e => e.OffresOffreId)
                    .HasName("IX_FK_OffreSpecialiteDiplome_Offres");

                entity.HasIndex(e => e.SpecialitesDiplomesSpecialiteDiplomeId)
                    .HasName("IX_FK_OffreSpecialiteDiplome_SpecialitesDiplome");

                entity.Property(e => e.OffresOffreId).HasColumnName("Offres_OffreId");

                entity.Property(e => e.SpecialitesDiplomesSpecialiteDiplomeId).HasColumnName("SpecialitesDiplomes_SpecialiteDiplomeId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.OffresOffre)
                    .WithMany(p => p.OffreSpecialiteDiplome)
                    .HasForeignKey(d => d.OffresOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreSpecialiteDiplome_Offres");

                entity.HasOne(d => d.SpecialitesDiplomesSpecialiteDiplome)
                    .WithMany(p => p.OffreSpecialiteDiplome)
                    .HasForeignKey(d => d.SpecialitesDiplomesSpecialiteDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreSpecialiteDiplome_SpecialitesDiplome");
            });

            modelBuilder.Entity<OffreStructureCompensation>(entity =>
            {
                entity.HasKey(e => new { e.OffresCompenseesOffreId, e.StructuresCompensationStructureId });

                entity.HasIndex(e => e.OffresCompenseesOffreId)
                    .HasName("IX_FK_OffreStructureCompensation_Offre");

                entity.HasIndex(e => e.StructuresCompensationStructureId)
                    .HasName("IX_FK_OffreStructureCompensation_Structure");

                entity.Property(e => e.OffresCompenseesOffreId).HasColumnName("OffresCompensees_OffreId");

                entity.Property(e => e.StructuresCompensationStructureId).HasColumnName("StructuresCompensation_StructureId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OffresCompenseesOffre)
                    .WithMany(p => p.OffreStructureCompensation)
                    .HasForeignKey(d => d.OffresCompenseesOffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreStructureCompensation_Offre");

                entity.HasOne(d => d.StructuresCompensationStructure)
                    .WithMany(p => p.OffreStructureCompensation)
                    .HasForeignKey(d => d.StructuresCompensationStructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreStructureCompensation_Structure");
            });

            modelBuilder.Entity<OnlineNotifications>(entity =>
            {
                entity.HasKey(e => e.OnlineNotificationId);

                entity.Property(e => e.OnlineNotificationId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DetailsUrl).HasMaxLength(2000);

                entity.Property(e => e.LongMessage).HasMaxLength(2000);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UrlParameters).HasMaxLength(2000);
            });

            modelBuilder.Entity<OptionsDiplomes>(entity =>
            {
                entity.HasKey(e => e.OptionDiplomeId);

                entity.HasIndex(e => e.SpecialiteDiplomeId)
                    .HasName("IX_FK_OptionDiplomeSpecialiteDiplome");

                entity.Property(e => e.OptionDiplomeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.SpecialiteDiplome)
                    .WithMany(p => p.OptionsDiplomes)
                    .HasForeignKey(d => d.SpecialiteDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OptionDiplomeSpecialiteDiplome");
            });

            modelBuilder.Entity<OrganismesAutresDispositifs>(entity =>
            {
                entity.HasKey(e => e.OrganismeAutreDispositifId);

                entity.Property(e => e.OrganismeAutreDispositifId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Orientations>(entity =>
            {
                entity.HasKey(e => e.OrientationId);

                entity.HasIndex(e => e.ConvocationEnLigneConvocationEnLigneId)
                    .HasName("IX_FK_ConvocationEnLigneOrientation");

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_OrientationDemande");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Orientations")
                    .IsUnique();

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_OrientationOffre");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantOrientation");

                entity.HasIndex(e => e.VisiteId)
                    .HasName("IX_FK_VisiteOrientation");

                entity.Property(e => e.OrientationId).ValueGeneratedNever();

                entity.Property(e => e.ConvocationEnLigneConvocationEnLigneId).HasColumnName("ConvocationEnLigne_ConvocationEnLigneId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateEcheance).HasColumnType("datetime");

                entity.Property(e => e.DateModificationEnLigne).HasColumnType("datetime");

                entity.Property(e => e.DateOrientation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRetourReponse).HasColumnType("datetime");

                entity.Property(e => e.Motif)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NumeroOld)
                    .HasColumnName("numero_old")
                    .HasMaxLength(32);

                entity.Property(e => e.Rapport).HasMaxLength(500);

                entity.HasOne(d => d.ConvocationEnLigneConvocationEnLigne)
                    .WithMany(p => p.Orientations)
                    .HasForeignKey(d => d.ConvocationEnLigneConvocationEnLigneId)
                    .HasConstraintName("FK_ConvocationEnLigneOrientation");

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.Orientations)
                    .HasForeignKey(d => d.DemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrientationDemande");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.Orientations)
                    .HasForeignKey(d => d.OffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrientationOffre");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orientations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantOrientation");

                entity.HasOne(d => d.Visite)
                    .WithMany(p => p.Orientations)
                    .HasForeignKey(d => d.VisiteId)
                    .HasConstraintName("FK_VisiteOrientation");
            });

            modelBuilder.Entity<Parametres>(entity =>
            {
                entity.HasKey(e => e.ParametreId);

                entity.Property(e => e.ParametreId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Valeur)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.Property(e => e.PaysId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NationaliteAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NationaliteFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Postulations>(entity =>
            {
                entity.HasKey(e => e.PostulationId);

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_DemandePostulation");

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_OffrePostulation");

                entity.Property(e => e.PostulationId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DatePostulation).HasColumnType("datetime");

                entity.Property(e => e.Motif)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.Postulations)
                    .HasForeignKey(d => d.DemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandePostulation");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.Postulations)
                    .HasForeignKey(d => d.OffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffrePostulation");
            });

            modelBuilder.Entity<ProfilActiviteBase>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsDemandeurId, e.ActivitesBaseActiviteBaseId });

                entity.HasIndex(e => e.ActivitesBaseActiviteBaseId)
                    .HasName("IX_FK_ProfilActiviteBase_ActiviteBase");

                entity.HasIndex(e => e.ProfilsDemandeurId)
                    .HasName("IX_FK_ProfilActiviteBase_Profil");

                entity.Property(e => e.ProfilsDemandeurId).HasColumnName("Profils_DemandeurId");

                entity.Property(e => e.ActivitesBaseActiviteBaseId).HasColumnName("ActivitesBase_ActiviteBaseId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesBaseActiviteBase)
                    .WithMany(p => p.ProfilActiviteBase)
                    .HasForeignKey(d => d.ActivitesBaseActiviteBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilActiviteBase_ActiviteBase");

                entity.HasOne(d => d.ProfilsDemandeur)
                    .WithMany(p => p.ProfilActiviteBase)
                    .HasForeignKey(d => d.ProfilsDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilActiviteBase_Profil");
            });

            modelBuilder.Entity<ProfilActiviteSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsDemandeurId, e.ActivitesSpecifiquesActiviteSpecifiqueId });

                entity.HasIndex(e => e.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .HasName("IX_FK_ProfilActiviteSpecifique_ActiviteSpecifique");

                entity.HasIndex(e => e.ProfilsDemandeurId)
                    .HasName("IX_FK_ProfilActiviteSpecifique_Profil");

                entity.Property(e => e.ProfilsDemandeurId).HasColumnName("Profils_DemandeurId");

                entity.Property(e => e.ActivitesSpecifiquesActiviteSpecifiqueId).HasColumnName("ActivitesSpecifiques_ActiviteSpecifiqueId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesSpecifiquesActiviteSpecifique)
                    .WithMany(p => p.ProfilActiviteSpecifique)
                    .HasForeignKey(d => d.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilActiviteSpecifique_ActiviteSpecifique");

                entity.HasOne(d => d.ProfilsDemandeur)
                    .WithMany(p => p.ProfilActiviteSpecifique)
                    .HasForeignKey(d => d.ProfilsDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilActiviteSpecifique_Profil");
            });

            modelBuilder.Entity<ProfilAvaliderActiviteBase>(entity =>
            {
                entity.HasKey(e => new { e.ProfilAvaliderActiviteBaseActiviteBaseDemandeurId, e.ActivitesBaseActiviteBaseId });

                entity.ToTable("ProfilAValiderActiviteBase");

                entity.HasIndex(e => e.ActivitesBaseActiviteBaseId)
                    .HasName("IX_FK_ProfilAValiderActiviteBase_ActiviteBase");

                entity.HasIndex(e => e.ProfilAvaliderActiviteBaseActiviteBaseDemandeurId)
                    .HasName("IX_FK_ProfilAValiderActiviteBase_ProfilAValider");

                entity.Property(e => e.ProfilAvaliderActiviteBaseActiviteBaseDemandeurId).HasColumnName("ProfilAValiderActiviteBase_ActiviteBase_DemandeurId");

                entity.Property(e => e.ActivitesBaseActiviteBaseId).HasColumnName("ActivitesBase_ActiviteBaseId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesBaseActiviteBase)
                    .WithMany(p => p.ProfilAvaliderActiviteBase)
                    .HasForeignKey(d => d.ActivitesBaseActiviteBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderActiviteBase_ActiviteBase");

                entity.HasOne(d => d.ProfilAvaliderActiviteBaseActiviteBaseDemandeur)
                    .WithMany(p => p.ProfilAvaliderActiviteBase)
                    .HasForeignKey(d => d.ProfilAvaliderActiviteBaseActiviteBaseDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderActiviteBase_ProfilAValider");
            });

            modelBuilder.Entity<ProfilAvaliderActiviteSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeurId, e.ActivitesSpecifiquesActiviteSpecifiqueId });

                entity.ToTable("ProfilAValiderActiviteSpecifique");

                entity.HasIndex(e => e.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .HasName("IX_FK_ProfilAValiderActiviteSpecifique_ActiviteSpecifique");

                entity.HasIndex(e => e.ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeurId)
                    .HasName("IX_FK_ProfilAValiderActiviteSpecifique_ProfilAValider");

                entity.Property(e => e.ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeurId).HasColumnName("ProfilAValiderActiviteSpecifique_ActiviteSpecifique_DemandeurId");

                entity.Property(e => e.ActivitesSpecifiquesActiviteSpecifiqueId).HasColumnName("ActivitesSpecifiques_ActiviteSpecifiqueId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ActivitesSpecifiquesActiviteSpecifique)
                    .WithMany(p => p.ProfilAvaliderActiviteSpecifique)
                    .HasForeignKey(d => d.ActivitesSpecifiquesActiviteSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderActiviteSpecifique_ActiviteSpecifique");

                entity.HasOne(d => d.ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeur)
                    .WithMany(p => p.ProfilAvaliderActiviteSpecifique)
                    .HasForeignKey(d => d.ProfilAvaliderActiviteSpecifiqueActiviteSpecifiqueDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderActiviteSpecifique_ProfilAValider");
            });

            modelBuilder.Entity<ProfilAvaliderCompetenceBase>(entity =>
            {
                entity.HasKey(e => new { e.ProfilAvaliderCompetenceBaseCompetenceBaseDemandeurId, e.CompetencesBaseCompetenceBaseId });

                entity.ToTable("ProfilAValiderCompetenceBase");

                entity.HasIndex(e => e.CompetencesBaseCompetenceBaseId)
                    .HasName("IX_FK_ProfilAValiderCompetenceBase_CompetenceBase");

                entity.HasIndex(e => e.ProfilAvaliderCompetenceBaseCompetenceBaseDemandeurId)
                    .HasName("IX_FK_ProfilAValiderCompetenceBase_ProfilAValider");

                entity.Property(e => e.ProfilAvaliderCompetenceBaseCompetenceBaseDemandeurId).HasColumnName("ProfilAValiderCompetenceBase_CompetenceBase_DemandeurId");

                entity.Property(e => e.CompetencesBaseCompetenceBaseId).HasColumnName("CompetencesBase_CompetenceBaseId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesBaseCompetenceBase)
                    .WithMany(p => p.ProfilAvaliderCompetenceBase)
                    .HasForeignKey(d => d.CompetencesBaseCompetenceBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderCompetenceBase_CompetenceBase");

                entity.HasOne(d => d.ProfilAvaliderCompetenceBaseCompetenceBaseDemandeur)
                    .WithMany(p => p.ProfilAvaliderCompetenceBase)
                    .HasForeignKey(d => d.ProfilAvaliderCompetenceBaseCompetenceBaseDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderCompetenceBase_ProfilAValider");
            });

            modelBuilder.Entity<ProfilAvaliderCompetenceSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeurId, e.CompetencesSpecifiquesCompetenceSpecifiqueId });

                entity.ToTable("ProfilAValiderCompetenceSpecifique");

                entity.HasIndex(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .HasName("IX_FK_ProfilAValiderCompetenceSpecifique_CompetenceSpecifique");

                entity.HasIndex(e => e.ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeurId)
                    .HasName("IX_FK_ProfilAValiderCompetenceSpecifique_ProfilAValider");

                entity.Property(e => e.ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeurId).HasColumnName("ProfilAValiderCompetenceSpecifique_CompetenceSpecifique_DemandeurId");

                entity.Property(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId).HasColumnName("CompetencesSpecifiques_CompetenceSpecifiqueId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesSpecifiquesCompetenceSpecifique)
                    .WithMany(p => p.ProfilAvaliderCompetenceSpecifique)
                    .HasForeignKey(d => d.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderCompetenceSpecifique_CompetenceSpecifique");

                entity.HasOne(d => d.ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeur)
                    .WithMany(p => p.ProfilAvaliderCompetenceSpecifique)
                    .HasForeignKey(d => d.ProfilAvaliderCompetenceSpecifiqueCompetenceSpecifiqueDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderCompetenceSpecifique_ProfilAValider");
            });

            modelBuilder.Entity<ProfilAvaliderFicheName>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsAvaliderDemandeurId, e.MetiersAcquisFicheNameId });

                entity.ToTable("ProfilAValiderFicheName");

                entity.HasIndex(e => e.MetiersAcquisFicheNameId)
                    .HasName("IX_FK_ProfilAValiderFicheName_FicheName");

                entity.HasIndex(e => e.ProfilsAvaliderDemandeurId)
                    .HasName("IX_FK_ProfilAValiderFicheName_ProfilAValider");

                entity.Property(e => e.ProfilsAvaliderDemandeurId).HasColumnName("ProfilsAValider_DemandeurId");

                entity.Property(e => e.MetiersAcquisFicheNameId).HasColumnName("MetiersAcquis_FicheNameId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.ProfilsAvaliderDemandeur)
                    .WithMany(p => p.ProfilAvaliderFicheName)
                    .HasForeignKey(d => d.ProfilsAvaliderDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilAValiderFicheName_ProfilAValider");
            });

            modelBuilder.Entity<ProfilCompetenceBase>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsDemandeurId, e.CompetencesBaseCompetenceBaseId });

                entity.HasIndex(e => e.CompetencesBaseCompetenceBaseId)
                    .HasName("IX_FK_ProfilCompetenceBase_CompetenceBase");

                entity.HasIndex(e => e.ProfilsDemandeurId)
                    .HasName("IX_FK_ProfilCompetenceBase_Profil");

                entity.Property(e => e.ProfilsDemandeurId).HasColumnName("Profils_DemandeurId");

                entity.Property(e => e.CompetencesBaseCompetenceBaseId).HasColumnName("CompetencesBase_CompetenceBaseId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesBaseCompetenceBase)
                    .WithMany(p => p.ProfilCompetenceBase)
                    .HasForeignKey(d => d.CompetencesBaseCompetenceBaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilCompetenceBase_CompetenceBase");

                entity.HasOne(d => d.ProfilsDemandeur)
                    .WithMany(p => p.ProfilCompetenceBase)
                    .HasForeignKey(d => d.ProfilsDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilCompetenceBase_Profil");
            });

            modelBuilder.Entity<ProfilCompetenceSpecifique>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsDemandeurId, e.CompetencesSpecifiquesCompetenceSpecifiqueId });

                entity.HasIndex(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .HasName("IX_FK_ProfilCompetenceSpecifique_CompetenceSpecifique");

                entity.HasIndex(e => e.ProfilsDemandeurId)
                    .HasName("IX_FK_ProfilCompetenceSpecifique_Profil");

                entity.Property(e => e.ProfilsDemandeurId).HasColumnName("Profils_DemandeurId");

                entity.Property(e => e.CompetencesSpecifiquesCompetenceSpecifiqueId).HasColumnName("CompetencesSpecifiques_CompetenceSpecifiqueId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.CompetencesSpecifiquesCompetenceSpecifique)
                    .WithMany(p => p.ProfilCompetenceSpecifique)
                    .HasForeignKey(d => d.CompetencesSpecifiquesCompetenceSpecifiqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilCompetenceSpecifique_CompetenceSpecifique");

                entity.HasOne(d => d.ProfilsDemandeur)
                    .WithMany(p => p.ProfilCompetenceSpecifique)
                    .HasForeignKey(d => d.ProfilsDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilCompetenceSpecifique_Profil");
            });

            modelBuilder.Entity<ProfilFicheName>(entity =>
            {
                entity.HasKey(e => new { e.ProfilsDemandeurId, e.MetiersAcquisFicheNameId });

                entity.HasIndex(e => e.MetiersAcquisFicheNameId)
                    .HasName("IX_FK_ProfilFicheName_FicheName");

                entity.HasIndex(e => e.ProfilsDemandeurId)
                    .HasName("IX_FK_ProfilFicheName_Profil");

                entity.Property(e => e.ProfilsDemandeurId).HasColumnName("Profils_DemandeurId");

                entity.Property(e => e.MetiersAcquisFicheNameId).HasColumnName("MetiersAcquis_FicheNameId");

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.MetiersAcquisFicheName)
                    .WithMany(p => p.ProfilFicheName)
                    .HasForeignKey(d => d.MetiersAcquisFicheNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilFicheName_FicheName");

                entity.HasOne(d => d.ProfilsDemandeur)
                    .WithMany(p => p.ProfilFicheName)
                    .HasForeignKey(d => d.ProfilsDemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilFicheName_Profil");
            });

            modelBuilder.Entity<Profils>(entity =>
            {
                entity.HasKey(e => e.DemandeurId);

                entity.HasIndex(e => e.NiveauInstructionId)
                    .HasName("IX_FK_ProfilNiveauInstruction");

                entity.HasIndex(e => e.NiveauQualificationId)
                    .HasName("IX_FK_ProfilNiveauQualification");

                entity.Property(e => e.DemandeurId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Demandeur)
                    .WithOne(p => p.Profils)
                    .HasForeignKey<Profils>(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilDemandeur");

                entity.HasOne(d => d.NiveauInstruction)
                    .WithMany(p => p.Profils)
                    .HasForeignKey(d => d.NiveauInstructionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilNiveauInstruction");

                entity.HasOne(d => d.NiveauQualification)
                    .WithMany(p => p.Profils)
                    .HasForeignKey(d => d.NiveauQualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfilNiveauQualification");
            });

            modelBuilder.Entity<ProfilsAvalider>(entity =>
            {
                entity.HasKey(e => e.DemandeurId);

                entity.ToTable("ProfilsAValider");

                entity.HasIndex(e => e.NiveauInstructionId)
                    .HasName("IX_FK_NiveauInstructionProfilAValider");

                entity.HasIndex(e => e.NiveauQualificationId)
                    .HasName("IX_FK_NiveauQualificationProfilAValider");

                entity.Property(e => e.DemandeurId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Demandeur)
                    .WithOne(p => p.ProfilsAvalider)
                    .HasForeignKey<ProfilsAvalider>(d => d.DemandeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DemandeurAValiderProfilAValider");

                entity.HasOne(d => d.NiveauInstruction)
                    .WithMany(p => p.ProfilsAvalider)
                    .HasForeignKey(d => d.NiveauInstructionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NiveauInstructionProfilAValider");

                entity.HasOne(d => d.NiveauQualification)
                    .WithMany(p => p.ProfilsAvalider)
                    .HasForeignKey(d => d.NiveauQualificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NiveauQualificationProfilAValider");
            });

            modelBuilder.Entity<PropositionsReferentiel>(entity =>
            {
                entity.HasKey(e => e.PropositionReferentielId);

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructurePropositionReferentiel");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantPropositionReferentiel");

                entity.Property(e => e.PropositionReferentielId).ValueGeneratedNever();

                entity.Property(e => e.DetailProposition).HasMaxLength(1000);

                entity.Property(e => e.IntitulePropose)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NomReferentiel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.PropositionsReferentiel)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructurePropositionReferentiel");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PropositionsReferentiel)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantPropositionReferentiel");
            });

            modelBuilder.Entity<ProspectionIntervenant>(entity =>
            {
                entity.HasKey(e => new { e.ProspectionsProspectionId, e.IntervenantsUserId });

                entity.HasIndex(e => e.IntervenantsUserId)
                    .HasName("IX_FK_ProspectionIntervenant_Intervenant");

                entity.HasIndex(e => e.ProspectionsProspectionId)
                    .HasName("IX_FK_ProspectionIntervenant_Prospection");

                entity.Property(e => e.ProspectionsProspectionId).HasColumnName("Prospections_ProspectionId");

                entity.Property(e => e.IntervenantsUserId).HasColumnName("Intervenants_UserId");

                entity.HasOne(d => d.IntervenantsUser)
                    .WithMany(p => p.ProspectionIntervenant)
                    .HasForeignKey(d => d.IntervenantsUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectionIntervenant_Intervenant");

                entity.HasOne(d => d.ProspectionsProspection)
                    .WithMany(p => p.ProspectionIntervenant)
                    .HasForeignKey(d => d.ProspectionsProspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectionIntervenant_Prospection");
            });

            modelBuilder.Entity<ProspectionObjectifProspection>(entity =>
            {
                entity.HasKey(e => new { e.ObjectifsProspectionsObjectifProspectionId, e.ProspectionsProspectionId });

                entity.HasIndex(e => e.ObjectifsProspectionsObjectifProspectionId)
                    .HasName("IX_FK_ProspectionObjectifProspection_ObjectifsProspections");

                entity.HasIndex(e => e.ProspectionsProspectionId)
                    .HasName("IX_FK_ProspectionObjectifProspection_Prospections");

                entity.Property(e => e.ObjectifsProspectionsObjectifProspectionId).HasColumnName("ObjectifsProspections_ObjectifProspectionId");

                entity.Property(e => e.ProspectionsProspectionId).HasColumnName("Prospections_ProspectionId");

                entity.HasOne(d => d.ObjectifsProspectionsObjectifProspection)
                    .WithMany(p => p.ProspectionObjectifProspection)
                    .HasForeignKey(d => d.ObjectifsProspectionsObjectifProspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectionObjectifProspection_ObjectifsProspections");

                entity.HasOne(d => d.ProspectionsProspection)
                    .WithMany(p => p.ProspectionObjectifProspection)
                    .HasForeignKey(d => d.ProspectionsProspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectionObjectifProspection_Prospections");
            });

            modelBuilder.Entity<Prospections>(entity =>
            {
                entity.HasKey(e => e.ProspectionId);

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Prospections")
                    .IsUnique();

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructureProspection");

                entity.Property(e => e.ProspectionId).ValueGeneratedNever();

                entity.Property(e => e.AutreObjectif).HasMaxLength(500);

                entity.Property(e => e.DateProspection).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(200);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Prospections)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureProspection");
            });

            modelBuilder.Entity<QrCode>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Qrcode1)
                    .IsRequired()
                    .HasColumnName("QRCode")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quartiers>(entity =>
            {
                entity.HasKey(e => e.QuartierId);

                entity.HasIndex(e => e.SecteurUrbainId)
                    .HasName("IX_FK_SecteurUrbainQuartier");

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_StructureQuartier");

                entity.Property(e => e.QuartierId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.SecteurUrbain)
                    .WithMany(p => p.Quartiers)
                    .HasForeignKey(d => d.SecteurUrbainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecteurUrbainQuartier");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Quartiers)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StructureQuartier");
            });

            modelBuilder.Entity<RaisonsSortieDispositif>(entity =>
            {
                entity.HasKey(e => e.RaisonSortieDispositifId);

                entity.Property(e => e.RaisonSortieDispositifId).ValueGeneratedNever();

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Rapprochements>(entity =>
            {
                entity.HasKey(e => e.RapprochementId);

                entity.HasIndex(e => e.DemandeId)
                    .HasName("IX_FK_RapprochementDemande");

                entity.HasIndex(e => e.OffreId)
                    .HasName("IX_FK_RapprochementOffre");

                entity.Property(e => e.RapprochementId).ValueGeneratedNever();

                entity.Property(e => e.ByOnline)
                    .HasColumnName("By_Online")
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Demande)
                    .WithMany(p => p.Rapprochements)
                    .HasForeignKey(d => d.DemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RapprochementDemande");

                entity.HasOne(d => d.Offre)
                    .WithMany(p => p.Rapprochements)
                    .HasForeignKey(d => d.OffreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RapprochementOffre");
            });

            modelBuilder.Entity<Secteurs>(entity =>
            {
                entity.HasKey(e => e.SecteurId);

                entity.Property(e => e.SecteurId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodeSecteur)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SecteursActivites>(entity =>
            {
                entity.HasKey(e => e.SecteurActiviteId);

                entity.Property(e => e.SecteurActiviteId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SecteursJuridiques>(entity =>
            {
                entity.HasKey(e => e.SecteurJuridiqueId);

                entity.Property(e => e.SecteurJuridiqueId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SecteursUrbains>(entity =>
            {
                entity.HasKey(e => e.SecteurUrbainId);

                entity.HasIndex(e => e.CommuneId)
                    .HasName("IX_FK_CommuneSecteurUrbain");

                entity.Property(e => e.SecteurUrbainId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.SecteursUrbains)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommuneSecteurUrbain");
            });

            modelBuilder.Entity<Sequences>(entity =>
            {
                entity.HasKey(e => e.SequenceId);

                entity.Property(e => e.SequenceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SituationsServiceMilitaires>(entity =>
            {
                entity.HasKey(e => e.SituationServiceMilitaireId);

                entity.Property(e => e.SituationServiceMilitaireId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SourcesDiplomes>(entity =>
            {
                entity.HasKey(e => e.SourceDiplomeId);

                entity.Property(e => e.SourceDiplomeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SousBranchesActivites>(entity =>
            {
                entity.HasKey(e => e.SousBrancheActiviteId);

                entity.HasIndex(e => e.BrancheActiviteId)
                    .HasName("IX_FK_SousBrancheActiviteBrancheActivite");

                entity.Property(e => e.SousBrancheActiviteId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.BrancheActivite)
                    .WithMany(p => p.SousBranchesActivites)
                    .HasForeignKey(d => d.BrancheActiviteId)
                    .HasConstraintName("FK_SousBrancheActiviteBrancheActivite");
            });

            modelBuilder.Entity<SousDomaines>(entity =>
            {
                entity.HasKey(e => e.SousDomaineId);

                entity.HasIndex(e => e.DomaineId)
                    .HasName("IX_FK_DomaineSousDomaine");

                entity.Property(e => e.SousDomaineId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CodeSousDomaine)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Domaine)
                    .WithMany(p => p.SousDomaines)
                    .HasForeignKey(d => d.DomaineId)
                    .HasConstraintName("FK_DomaineSousDomaine");
            });

            modelBuilder.Entity<SpecialitesDiplomes>(entity =>
            {
                entity.HasKey(e => e.SpecialiteDiplomeId);

                entity.HasIndex(e => e.TypeDiplomeId)
                    .HasName("IX_FK_TypeDiplomeSpecialiteDiplome");

                entity.Property(e => e.SpecialiteDiplomeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.FiliereId).HasColumnName("FiliereID");

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Filiere)
                    .WithMany(p => p.SpecialitesDiplomes)
                    .HasForeignKey(d => d.FiliereId)
                    .HasConstraintName("FK_SpecialitesDiplomes_Filiere");

                entity.HasOne(d => d.TypeDiplome)
                    .WithMany(p => p.SpecialitesDiplomes)
                    .HasForeignKey(d => d.TypeDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeDiplomeSpecialiteDiplome");
            });

            modelBuilder.Entity<StatutsJuridiques>(entity =>
            {
                entity.HasKey(e => e.StatutJuridiqueId);

                entity.Property(e => e.StatutJuridiqueId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Structures>(entity =>
            {
                entity.HasKey(e => e.StructureId);

                entity.HasIndex(e => e.StructureParentId)
                    .HasName("IX_FK_StructureStructure");

                entity.HasIndex(e => e.WilayaId)
                    .HasName("IX_FK_WilayaStructure");

                entity.Property(e => e.StructureId).ValueGeneratedNever();

                entity.Property(e => e.AdresseAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AdresseFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CanOutsidePlacement)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.PageFbNom).HasMaxLength(255);

                entity.Property(e => e.Responsable).HasMaxLength(200);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.StructureParent)
                    .WithMany(p => p.InverseStructureParent)
                    .HasForeignKey(d => d.StructureParentId)
                    .HasConstraintName("FK_StructureStructure");

                entity.HasOne(d => d.Wilaya)
                    .WithMany(p => p.Structures)
                    .HasForeignKey(d => d.WilayaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WilayaStructure");
            });

            modelBuilder.Entity<Traces>(entity =>
            {
                entity.HasKey(e => e.TraceId);

                entity.HasIndex(e => e.StructureId)
                    .HasName("IX_FK_TraceStructure");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantTrace");

                entity.Property(e => e.TraceId).ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EntitySet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Machine)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.NomAction)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ParentEntitySet).HasMaxLength(50);

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.Traces)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TraceStructure");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Traces)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantTrace");
            });

            modelBuilder.Entity<TypeContratNatureDemande>(entity =>
            {
                entity.HasKey(e => new { e.TypesContratTypeContratId, e.NaturesDemandeNatureDemandeId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.NaturesDemandeNatureDemandeId)
                    .HasName("IX_FK_TypeContratNatureDemande_NatureDemande");

                entity.HasIndex(e => e.TypesContratTypeContratId)
                    .HasName("IX_FK_TypeContratNatureDemande_TypeContrat")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.TypesContratTypeContratId).HasColumnName("TypesContrat_TypeContratId");

                entity.Property(e => e.NaturesDemandeNatureDemandeId).HasColumnName("NaturesDemande_NatureDemandeId");

                entity.HasOne(d => d.NaturesDemandeNatureDemande)
                    .WithMany(p => p.TypeContratNatureDemande)
                    .HasForeignKey(d => d.NaturesDemandeNatureDemandeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratNatureDemande_NatureDemande");

                entity.HasOne(d => d.TypesContratTypeContrat)
                    .WithMany(p => p.TypeContratNatureDemande)
                    .HasForeignKey(d => d.TypesContratTypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratNatureDemande_TypeContrat");
            });

            modelBuilder.Entity<TypeDocument>(entity =>
            {
                entity.HasKey(e => e.TypeDocument1);

                entity.Property(e => e.TypeDocument1).HasColumnName("TypeDocument");

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasColumnName("IntituleFR")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TypesContratReconduction>(entity =>
            {
                entity.HasKey(e => new { e.TypesContratsSourceReconductionTypeContratId, e.TypesContratsEligiblesReconductionTypeContratId });

                entity.HasIndex(e => e.TypesContratsEligiblesReconductionTypeContratId)
                    .HasName("IX_FK_TypeContratTypeContrat_TypeContrat1");

                entity.HasIndex(e => e.TypesContratsSourceReconductionTypeContratId)
                    .HasName("IX_FK_TypeContratTypeContrat_TypeContrat");

                entity.Property(e => e.TypesContratsSourceReconductionTypeContratId).HasColumnName("TypesContratsSourceReconduction_TypeContratId");

                entity.Property(e => e.TypesContratsEligiblesReconductionTypeContratId).HasColumnName("TypesContratsEligiblesReconduction_TypeContratId");

                entity.HasOne(d => d.TypesContratsEligiblesReconductionTypeContrat)
                    .WithMany(p => p.TypesContratReconductionTypesContratsEligiblesReconductionTypeContrat)
                    .HasForeignKey(d => d.TypesContratsEligiblesReconductionTypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratTypeContrat_TypeContrat1");

                entity.HasOne(d => d.TypesContratsSourceReconductionTypeContrat)
                    .WithMany(p => p.TypesContratReconductionTypesContratsSourceReconductionTypeContrat)
                    .HasForeignKey(d => d.TypesContratsSourceReconductionTypeContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeContratTypeContrat_TypeContrat");
            });

            modelBuilder.Entity<TypesContrats>(entity =>
            {
                entity.HasKey(e => e.TypeContratId);

                entity.HasIndex(e => e.CategorieContratId)
                    .HasName("IX_FK_CategorieContratTypeContrat");

                entity.HasIndex(e => e.SecteurActiviteId)
                    .HasName("IX_FK_SecteurActiviteTypeContrat");

                entity.Property(e => e.TypeContratId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MontantAide).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.CategorieContrat)
                    .WithMany(p => p.TypesContrats)
                    .HasForeignKey(d => d.CategorieContratId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategorieContratTypeContrat");

                entity.HasOne(d => d.SecteurActivite)
                    .WithMany(p => p.TypesContrats)
                    .HasForeignKey(d => d.SecteurActiviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecteurActiviteTypeContrat");
            });

            modelBuilder.Entity<TypesDiplomes>(entity =>
            {
                entity.HasKey(e => e.TypeDiplomeId);

                entity.HasIndex(e => e.SourceDiplomeId)
                    .HasName("IX_FK_SourceDiplomeTypeDiplome");

                entity.Property(e => e.TypeDiplomeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.SourceDiplome)
                    .WithMany(p => p.TypesDiplomes)
                    .HasForeignKey(d => d.SourceDiplomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SourceDiplomeTypeDiplome");
            });

            modelBuilder.Entity<TypesHandicaps>(entity =>
            {
                entity.HasKey(e => e.TypeHandicapId);

                entity.Property(e => e.TypeHandicapId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TypesPiecesIdentites>(entity =>
            {
                entity.HasKey(e => e.TypePieceIdentiteId);

                entity.Property(e => e.TypePieceIdentiteId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Visites>(entity =>
            {
                entity.HasKey(e => e.VisiteId);

                entity.HasIndex(e => e.EmployeurId)
                    .HasName("IX_FK_VisiteEmployeur");

                entity.HasIndex(e => e.Numero)
                    .HasName("UK_Numero_Visites")
                    .IsUnique();

                entity.HasIndex(e => e.ProspectionId)
                    .HasName("IX_FK_VisiteProspection");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_IntervenantVisite");

                entity.Property(e => e.VisiteId).ValueGeneratedNever();

                entity.Property(e => e.DateReport).HasColumnType("datetime");

                entity.Property(e => e.DateVisite).HasColumnType("datetime");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Rapport).HasMaxLength(500);

                entity.HasOne(d => d.Employeur)
                    .WithMany(p => p.Visites)
                    .HasForeignKey(d => d.EmployeurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisiteEmployeur");

                entity.HasOne(d => d.Prospection)
                    .WithMany(p => p.Visites)
                    .HasForeignKey(d => d.ProspectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VisiteProspection");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Visites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntervenantVisite");
            });

            modelBuilder.Entity<Wilayas>(entity =>
            {
                entity.HasKey(e => e.WilayaId);

                entity.HasIndex(e => e.PaysId)
                    .HasName("IX_FK_PaysWilaya");

                entity.Property(e => e.WilayaId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.IntituleAr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IntituleFr)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Pays)
                    .WithMany(p => p.Wilayas)
                    .HasForeignKey(d => d.PaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaysWilaya");
            });
        }
    }
}
