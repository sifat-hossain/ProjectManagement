using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjectManagement.Models;

#nullable disable

namespace ProjectManagement.Data
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bureau> Bureaus { get; set; }
        public virtual DbSet<CompletedProject> CompletedProjects { get; set; }
        public virtual DbSet<CostEstimationCommittee> CostEstimationCommittees { get; set; }
        public virtual DbSet<CostEstimationCommitteeMember> CostEstimationCommitteeMembers { get; set; }
        public virtual DbSet<DefectWithingWarranty> DefectWithingWarranties { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Evalution> Evalutions { get; set; }
        public virtual DbSet<EvalutionCommitteemember> EvalutionCommitteemembers { get; set; }
        public virtual DbSet<FacMember> FacMembers { get; set; }
        public virtual DbSet<FinalAcceptance> FinalAcceptances { get; set; }
        public virtual DbSet<FinalApproval> FinalApprovals { get; set; }
        public virtual DbSet<FinalContract> FinalContracts { get; set; }
        public virtual DbSet<ForceRank> ForceRanks { get; set; }
        public virtual DbSet<InitialNotesheet> InitialNotesheets { get; set; }
        public virtual DbSet<IvitationForTender> IvitationForTenders { get; set; }
        public virtual DbSet<Lc> Lcs { get; set; }
        public virtual DbSet<Noa> Noas { get; set; }
        public virtual DbSet<NoaAcceptance> NoaAcceptances { get; set; }
        public virtual DbSet<PacMember> PacMembers { get; set; }
        public virtual DbSet<PgVerification> PgVerifications { get; set; }
        public virtual DbSet<Pgd> Pgds { get; set; }
        public virtual DbSet<PgdwithProduct> PgdwithProducts { get; set; }
        public virtual DbSet<Pi> Pis { get; set; }
        public virtual DbSet<Po> Pos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectDetail> ProjectDetails { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
        public virtual DbSet<ProvisionalAcceptance> ProvisionalAcceptances { get; set; }
        public virtual DbSet<Psi> Psis { get; set; }
        public virtual DbSet<PsiMember> PsiMembers { get; set; }
        public virtual DbSet<RankType> RankTypes { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<TechSpecCommittee> TechSpecCommittees { get; set; }
        public virtual DbSet<TechSpecCommitteeMember> TechSpecCommitteeMembers { get; set; }
        public virtual DbSet<TenderOpening> TenderOpenings { get; set; }
        public virtual DbSet<TrainingMember> TrainingMembers { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VendorContactPersonDesignation> VendorContactPersonDesignations { get; set; }
        public virtual DbSet<VendorContactPersonInformation> VendorContactPersonInformations { get; set; }
        public virtual DbSet<VendorInformation> VendorInformations { get; set; }
        public virtual DbSet<Warranty> Warranties { get; set; }
        public virtual DbSet<training> training { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Bureau>(entity =>
            {
                entity.ToTable("Bureau");

                entity.Property(e => e.BureauFullName).HasMaxLength(100);

                entity.Property(e => e.BureauName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CompletedProject>(entity =>
            {
                entity.ToTable("CompletedProject");

                entity.Property(e => e.ContractDate).HasColumnType("date");

                entity.Property(e => e.PgexpiredDate)
                    .HasColumnType("date")
                    .HasColumnName("PGExpiredDate");

                entity.Property(e => e.WarrantyExpiredDate).HasColumnType("date");
            });

            modelBuilder.Entity<CostEstimationCommittee>(entity =>
            {
                entity.ToTable("CostEstimationCommittee");

                entity.Property(e => e.CostEstimationCommitteeOpeningDate).HasColumnType("date");

                entity.Property(e => e.EstimatedCost).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CostEstimationCommitteeMember)
                    .WithMany(p => p.CostEstimationCommittees)
                    .HasForeignKey(d => d.CostEstimationCommitteeMemberId)
                    .HasConstraintName("FK__CostEstim__CostE__4CA06362");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CostEstimationCommittees)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__CostEstim__Proje__4BAC3F29");
            });

            modelBuilder.Entity<CostEstimationCommitteeMember>(entity =>
            {
                entity.ToTable("CostEstimationCommitteeMember");

                entity.Property(e => e.CostEstimationCommitteeMemberCreateDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CostEstimationCommitteeMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__CostEstim__Proje__48CFD27E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CostEstimationCommitteeMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CostEstim__UserI__47DBAE45");
            });

            modelBuilder.Entity<DefectWithingWarranty>(entity =>
            {
                entity.ToTable("DefectWithingWarranty");

                entity.Property(e => e.InformDate).HasColumnType("date");

                entity.Property(e => e.SupportEnd).HasColumnType("date");

                entity.Property(e => e.SupportStart).HasColumnType("date");

                entity.Property(e => e.SupportStatus).HasMaxLength(100);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DefectWithingWarranties)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__DefectWit__Produ__22751F6C");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DefectWithingWarranties)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__DefectWit__Proje__2180FB33");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.DesignationName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Evalution>(entity =>
            {
                entity.ToTable("Evalution");

                entity.Property(e => e.EvalutionMeetingDate).HasColumnType("date");

                entity.Property(e => e.FinalContractPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.EvalutionCommitteemember)
                    .WithMany(p => p.Evalutions)
                    .HasForeignKey(d => d.EvalutionCommitteememberId)
                    .HasConstraintName("FK__Evalution__Evalu__5AEE82B9");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Evalutions)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Evalution__Evalu__59FA5E80");
            });

            modelBuilder.Entity<EvalutionCommitteemember>(entity =>
            {
                entity.ToTable("EvalutionCommitteemember");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EvalutionCommitteemembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Evalution__Proje__571DF1D5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EvalutionCommitteemembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Evalution__UserI__5629CD9C");
            });

            modelBuilder.Entity<FacMember>(entity =>
            {
                entity.ToTable("FacMember");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FacMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__FacMember__Proje__160F4887");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FacMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FacMember__UserI__151B244E");
            });

            modelBuilder.Entity<FinalAcceptance>(entity =>
            {
                entity.ToTable("FinalAcceptance");

                entity.Property(e => e.FinalAcceptanceDate).HasColumnType("date");

                entity.Property(e => e.FinalAcceptanceStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FacMember)
                    .WithMany(p => p.FinalAcceptances)
                    .HasForeignKey(d => d.FacMemberId)
                    .HasConstraintName("FK__FinalAcce__FacMe__1AD3FDA4");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FinalAcceptances)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__FinalAcce__Produ__19DFD96B");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FinalAcceptances)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__FinalAcce__Proje__18EBB532");
            });

            modelBuilder.Entity<FinalApproval>(entity =>
            {
                entity.ToTable("FinalApproval");

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FinalApprovals)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__FinalAppr__Proje__5EBF139D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FinalApprovals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__FinalAppr__UserI__5DCAEF64");
            });

            modelBuilder.Entity<FinalContract>(entity =>
            {
                entity.ToTable("FinalContract");

                entity.Property(e => e.ContractOpeningDate).HasColumnType("date");

                entity.Property(e => e.FinalContractPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.FinalContracts)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__FinalCont__Proje__6A30C649");
            });

            modelBuilder.Entity<ForceRank>(entity =>
            {
                entity.ToTable("ForceRank");

                entity.Property(e => e.ForceRankName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.RankType)
                    .WithMany(p => p.ForceRanks)
                    .HasForeignKey(d => d.RankTypeId)
                    .HasConstraintName("FK__ForceRank__RankT__182C9B23");
            });

            modelBuilder.Entity<InitialNotesheet>(entity =>
            {
                entity.ToTable("InitialNotesheet");

                entity.Property(e => e.InitialNoteSheetOpeningDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.InitialNotesheets)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__InitialNo__Proje__3C69FB99");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.InitialNotesheets)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__InitialNo__Vendo__3D5E1FD2");
            });

            modelBuilder.Entity<IvitationForTender>(entity =>
            {
                entity.ToTable("IvitationForTender");

                entity.Property(e => e.IvitationForTenderDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.IvitationForTenders)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Ivitation__Proje__4F7CD00D");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.IvitationForTenders)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__Ivitation__Vendo__5070F446");
            });

            modelBuilder.Entity<Lc>(entity =>
            {
                entity.ToTable("LC");

                entity.Property(e => e.Lcid).HasColumnName("LCId");

                entity.Property(e => e.Lcattachment).HasColumnName("LCAttachment");

                entity.Property(e => e.LcopeningDate)
                    .HasColumnType("date")
                    .HasColumnName("LCOpeningDate");

                entity.Property(e => e.NominatedBank).HasMaxLength(100);

                entity.Property(e => e.PaymentProcess).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Lcs)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__LC__ProjectId__72C60C4A");
            });

            modelBuilder.Entity<Noa>(entity =>
            {
                entity.ToTable("NOA");

                entity.Property(e => e.FinalContatractPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pgdate)
                    .HasColumnType("date")
                    .HasColumnName("PGDate");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Noas)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__NOA__ProjectId__619B8048");
            });

            modelBuilder.Entity<NoaAcceptance>(entity =>
            {
                entity.ToTable("NoaAcceptance");

                entity.Property(e => e.NoaAcceptanceDate).HasColumnType("date");

                entity.HasOne(d => d.Noa)
                    .WithMany(p => p.NoaAcceptances)
                    .HasForeignKey(d => d.NoaId)
                    .HasConstraintName("FK__NoaAccept__NoaId__6477ECF3");
            });

            modelBuilder.Entity<PacMember>(entity =>
            {
                entity.ToTable("PacMember");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PacMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__PacMember__Proje__0D7A0286");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PacMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PacMember__UserI__0C85DE4D");
            });

            modelBuilder.Entity<PgVerification>(entity =>
            {
                entity.ToTable("PgVerification");

                entity.Property(e => e.PgExpireDate).HasColumnType("date");

                entity.Property(e => e.PgOpeningDate).HasColumnType("date");

                entity.Property(e => e.PgPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Noa)
                    .WithMany(p => p.PgVerifications)
                    .HasForeignKey(d => d.NoaId)
                    .HasConstraintName("FK__PgVerific__NoaId__6754599E");
            });

            modelBuilder.Entity<Pgd>(entity =>
            {
                entity.ToTable("PGD");

                entity.Property(e => e.PgdDate).HasColumnType("date");

                entity.Property(e => e.PgdName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Pgds)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__PGD__ProjectId__300424B4");
            });

            modelBuilder.Entity<PgdwithProduct>(entity =>
            {
                entity.ToTable("PGDWithProduct");

                entity.Property(e => e.PgdwithProductId).HasColumnName("PGDWithProductId");

                entity.HasOne(d => d.Pgd)
                    .WithMany(p => p.PgdwithProducts)
                    .HasForeignKey(d => d.PgdId)
                    .HasConstraintName("FK__PGDWithPr__PgdId__32E0915F");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PgdwithProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__PGDWithPr__Produ__33D4B598");
            });

            modelBuilder.Entity<Pi>(entity =>
            {
                entity.ToTable("PI");

                entity.Property(e => e.Pidate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Pis)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__PI__ProjectId__6D0D32F4");
            });

            modelBuilder.Entity<Po>(entity =>
            {
                entity.ToTable("PO");

                entity.Property(e => e.Poid).HasColumnName("POId");

                entity.Property(e => e.Poattachment).HasColumnName("POAttachment");

                entity.Property(e => e.Podate)
                    .HasColumnType("date")
                    .HasColumnName("PODate");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Pos)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__PO__ProjectId__6FE99F9F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductBrand)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProductName).IsRequired();

                entity.Property(e => e.ProductOrigin).HasMaxLength(100);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectEndDate).HasColumnType("date");

                entity.Property(e => e.ProjectFinalBudget).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProjectInitialBudget).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProjectName).IsRequired();

                entity.Property(e => e.ProjectStartDate).HasColumnType("date");

                entity.HasOne(d => d.Bureau)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.BureauId)
                    .HasConstraintName("FK__Project__BureauI__276EDEB3");
            });

            modelBuilder.Entity<ProjectDetail>(entity =>
            {
                entity.ToTable("ProjectDetail");

                entity.Property(e => e.PgdwithProductId).HasColumnName("PGDWithProductId");

                entity.HasOne(d => d.PgdwithProduct)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.PgdwithProductId)
                    .HasConstraintName("FK__ProjectDe__PGDWi__398D8EEE");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__ProjectDe__Proje__36B12243");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ProjectDe__UserI__37A5467C");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ProjectDetails)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__ProjectDe__Vendo__38996AB5");
            });

            modelBuilder.Entity<ProjectUser>(entity =>
            {
                entity.ToTable("ProjectUser");

                entity.HasOne(d => d.Bureau)
                    .WithMany(p => p.ProjectUsers)
                    .HasForeignKey(d => d.BureauId)
                    .HasConstraintName("FK__ProjectUs__Burea__2B3F6F97");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectUsers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__ProjectUs__Proje__2A4B4B5E");
            });

            modelBuilder.Entity<ProvisionalAcceptance>(entity =>
            {
                entity.ToTable("ProvisionalAcceptance");

                entity.Property(e => e.AcceptanceStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProvisionalAcceptance1)
                    .HasColumnType("date")
                    .HasColumnName("ProvisionalAcceptance");

                entity.HasOne(d => d.PacMember)
                    .WithMany(p => p.ProvisionalAcceptances)
                    .HasForeignKey(d => d.PacMemberId)
                    .HasConstraintName("FK__Provision__PacMe__123EB7A3");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProvisionalAcceptances)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Provision__Produ__114A936A");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProvisionalAcceptances)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Provision__Proje__10566F31");
            });

            modelBuilder.Entity<Psi>(entity =>
            {
                entity.ToTable("Psi");

                entity.Property(e => e.PsiEndDate).HasColumnType("date");

                entity.Property(e => e.PsiLocation).HasMaxLength(100);

                entity.Property(e => e.PsiStartDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Psis)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Psi__ProjectId__797309D9");

                entity.HasOne(d => d.PsiMember)
                    .WithMany(p => p.Psis)
                    .HasForeignKey(d => d.PsiMemberId)
                    .HasConstraintName("FK__Psi__PsiMemberId__7A672E12");
            });

            modelBuilder.Entity<PsiMember>(entity =>
            {
                entity.ToTable("PsiMember");

                entity.Property(e => e.PsiMemberCreateDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PsiMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__PsiMember__Proje__76969D2E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PsiMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PsiMember__UserI__75A278F5");
            });

            modelBuilder.Entity<RankType>(entity =>
            {
                entity.ToTable("RankType");

                entity.Property(e => e.RankTypeName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");

                entity.Property(e => e.ShipmentFromCountry).HasMaxLength(100);

                entity.Property(e => e.ShipmentName).HasMaxLength(200);

                entity.Property(e => e.ShipmentReceivedDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Shipment__Projec__04E4BC85");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Shipment__UserId__05D8E0BE");
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.ToTable("ShipmentItem");

                entity.Property(e => e.ShipmentItemStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ShipmentI__Produ__09A971A2");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK__ShipmentI__Shipm__08B54D69");
            });

            modelBuilder.Entity<TechSpecCommittee>(entity =>
            {
                entity.ToTable("TechSpecCommittee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TechSpecCommittees)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TechSpecC__Proje__440B1D61");

                entity.HasOne(d => d.TechSpecCommitteeMember)
                    .WithMany(p => p.TechSpecCommittees)
                    .HasForeignKey(d => d.TechSpecCommitteeMemberId)
                    .HasConstraintName("FK__TechSpecC__TechS__44FF419A");
            });

            modelBuilder.Entity<TechSpecCommitteeMember>(entity =>
            {
                entity.ToTable("TechSpecCommitteeMember");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TechSpecCommitteeMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TechSpecC__Proje__412EB0B6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TechSpecCommitteeMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__TechSpecC__UserI__403A8C7D");
            });

            modelBuilder.Entity<TenderOpening>(entity =>
            {
                entity.ToTable("TenderOpening");

                entity.Property(e => e.TenderClosingDate).HasColumnType("date");

                entity.Property(e => e.TenderHonorium).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TenderOpeningDate).HasColumnType("date");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TenderOpenings)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TenderOpe__Proje__534D60F1");
            });

            modelBuilder.Entity<TrainingMember>(entity =>
            {
                entity.ToTable("TrainingMember");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TrainingMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__TrainingM__Proje__7E37BEF6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TrainingMembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__TrainingM__UserI__7D439ABD");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInfo__1788CC4C0538F532");

                entity.ToTable("UserInformation");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserEmail).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserInfor__Desig__1B0907CE");

                entity.HasOne(d => d.ForceRank)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.ForceRankId)
                    .HasConstraintName("FK__UserInfor__Force__1BFD2C07");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserInformations)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserInfor__UserR__1CF15040");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("UserLogin");

                entity.Property(e => e.LoginId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserLogin_UserInformation");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<VendorContactPersonDesignation>(entity =>
            {
                entity.ToTable("VendorContactPersonDesignation");

                entity.Property(e => e.VendorContactPersonDesignationName).HasMaxLength(200);
            });

            modelBuilder.Entity<VendorContactPersonInformation>(entity =>
            {
                entity.ToTable("VendorContactPersonInformation");

                entity.Property(e => e.VendorContactPersonEmail).IsRequired();

                entity.Property(e => e.VendorContactPersonName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VendorContactPersonPhone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.VendorContactPersonDesignation)
                    .WithMany(p => p.VendorContactPersonInformations)
                    .HasForeignKey(d => d.VendorContactPersonDesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VendorCon__Vendo__22AA2996");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorContactPersonInformations)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VendorCon__Vendo__21B6055D");
            });

            modelBuilder.Entity<VendorInformation>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("PK__VendorIn__FC8618F3813B877B");

                entity.ToTable("VendorInformation");

                entity.Property(e => e.VendorEmail).IsRequired();

                entity.Property(e => e.VendorName).IsRequired();

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VendorTradeLicenceNo).IsRequired();
            });

            modelBuilder.Entity<Warranty>(entity =>
            {
                entity.ToTable("Warranty");

                entity.Property(e => e.WarrantyEnd).HasColumnType("date");

                entity.Property(e => e.WarrantyStart).HasColumnType("date");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Warranties)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Warranty__Produc__1EA48E88");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Warranties)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Warranty__Projec__1DB06A4F");
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.ToTable("Training");

                entity.Property(e => e.TrainingEndDate).HasColumnType("date");

                entity.Property(e => e.TrainingLocation).HasMaxLength(100);

                entity.Property(e => e.TrainingStartDate).HasColumnType("date");

                entity.Property(e => e.TrainingTaDa).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.training)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK__Training__Projec__01142BA1");

                entity.HasOne(d => d.TrainingMember)
                    .WithMany(p => p.training)
                    .HasForeignKey(d => d.TrainingMemberId)
                    .HasConstraintName("FK__Training__Traini__02084FDA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
