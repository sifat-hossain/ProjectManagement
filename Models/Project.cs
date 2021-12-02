using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Project
    {
        public Project()
        {
            CostEstimationCommitteeMembers = new HashSet<CostEstimationCommitteeMember>();
            CostEstimationCommittees = new HashSet<CostEstimationCommittee>();
            DefectWithingWarranties = new HashSet<DefectWithingWarranty>();
            EvalutionCommitteemembers = new HashSet<EvalutionCommitteemember>();
            Evalutions = new HashSet<Evalution>();
            FacMembers = new HashSet<FacMember>();
            FinalAcceptances = new HashSet<FinalAcceptance>();
            FinalApprovals = new HashSet<FinalApproval>();
            FinalContracts = new HashSet<FinalContract>();
            InitialNotesheets = new HashSet<InitialNotesheet>();
            InvitationForTenders = new HashSet<InvitationForTender>();
            Lcs = new HashSet<Lc>();
            Noas = new HashSet<Noa>();
            PacMembers = new HashSet<PacMember>();
            Pgds = new HashSet<Pgd>();
            Pis = new HashSet<Pi>();
            Pos = new HashSet<Po>();
            ProjectDetails = new HashSet<ProjectDetail>();
            ProjectUsers = new HashSet<ProjectUser>();
            ProvisionalAcceptances = new HashSet<ProvisionalAcceptance>();
            PsiMembers = new HashSet<PsiMember>();
            Psis = new HashSet<Psi>();
            Shipments = new HashSet<Shipment>();
            TechSpecCommitteeMembers = new HashSet<TechSpecCommitteeMember>();
            TechSpecCommittees = new HashSet<TechSpecCommittee>();
            TenderOpenings = new HashSet<TenderOpening>();
            TrainingMembers = new HashSet<TrainingMember>();
            Warranties = new HashSet<Warranty>();
            training = new HashSet<training>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectInitialBudget { get; set; }
        public decimal? ProjectFinalBudget { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectAttachment { get; set; }
        public int? BureauId { get; set; }

        public virtual Bureau Bureau { get; set; }
        public virtual ICollection<CostEstimationCommitteeMember> CostEstimationCommitteeMembers { get; set; }
        public virtual ICollection<CostEstimationCommittee> CostEstimationCommittees { get; set; }
        public virtual ICollection<DefectWithingWarranty> DefectWithingWarranties { get; set; }
        public virtual ICollection<EvalutionCommitteemember> EvalutionCommitteemembers { get; set; }
        public virtual ICollection<Evalution> Evalutions { get; set; }
        public virtual ICollection<FacMember> FacMembers { get; set; }
        public virtual ICollection<FinalAcceptance> FinalAcceptances { get; set; }
        public virtual ICollection<FinalApproval> FinalApprovals { get; set; }
        public virtual ICollection<FinalContract> FinalContracts { get; set; }
        public virtual ICollection<InitialNotesheet> InitialNotesheets { get; set; }
        public virtual ICollection<InvitationForTender> InvitationForTenders { get; set; }
        public virtual ICollection<Lc> Lcs { get; set; }
        public virtual ICollection<Noa> Noas { get; set; }
        public virtual ICollection<PacMember> PacMembers { get; set; }
        public virtual ICollection<Pgd> Pgds { get; set; }
        public virtual ICollection<Pi> Pis { get; set; }
        public virtual ICollection<Po> Pos { get; set; }
        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
        public virtual ICollection<ProjectUser> ProjectUsers { get; set; }
        public virtual ICollection<ProvisionalAcceptance> ProvisionalAcceptances { get; set; }
        public virtual ICollection<PsiMember> PsiMembers { get; set; }
        public virtual ICollection<Psi> Psis { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<TechSpecCommitteeMember> TechSpecCommitteeMembers { get; set; }
        public virtual ICollection<TechSpecCommittee> TechSpecCommittees { get; set; }
        public virtual ICollection<TenderOpening> TenderOpenings { get; set; }
        public virtual ICollection<TrainingMember> TrainingMembers { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
        public virtual ICollection<training> training { get; set; }
    }
}
