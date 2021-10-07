using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class UserInformation
    {
        public UserInformation()
        {
            CostEstimationCommitteeMembers = new HashSet<CostEstimationCommitteeMember>();
            EvalutionCommitteemembers = new HashSet<EvalutionCommitteemember>();
            FacMembers = new HashSet<FacMember>();
            FinalApprovals = new HashSet<FinalApproval>();
            PacMembers = new HashSet<PacMember>();
            ProjectDetails = new HashSet<ProjectDetail>();
            PsiMembers = new HashSet<PsiMember>();
            Shipments = new HashSet<Shipment>();
            TechSpecCommitteeMembers = new HashSet<TechSpecCommitteeMember>();
            TrainingMembers = new HashSet<TrainingMember>();
            UserLogins = new HashSet<UserLogin>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int DesignationId { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImage { get; set; }
        public string UserEmail { get; set; }
        public int UserDgfiId { get; set; }
        public bool? UserType { get; set; }
        public int? ForceRankId { get; set; }
        public int UserRoleId { get; set; }

        public virtual Designation Designation { get; set; }
        public virtual ForceRank ForceRank { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<CostEstimationCommitteeMember> CostEstimationCommitteeMembers { get; set; }
        public virtual ICollection<EvalutionCommitteemember> EvalutionCommitteemembers { get; set; }
        public virtual ICollection<FacMember> FacMembers { get; set; }
        public virtual ICollection<FinalApproval> FinalApprovals { get; set; }
        public virtual ICollection<PacMember> PacMembers { get; set; }
        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
        public virtual ICollection<PsiMember> PsiMembers { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<TechSpecCommitteeMember> TechSpecCommitteeMembers { get; set; }
        public virtual ICollection<TrainingMember> TrainingMembers { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
