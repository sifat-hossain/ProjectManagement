USE [ProjectManagementDB]
GO
/****** Object:  Table [dbo].[Bureau]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bureau](
	[BureauId] [int] IDENTITY(1,1) NOT NULL,
	[BureauName] [nvarchar](10) NOT NULL,
	[BureauFullName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[BureauId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompletedProject]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompletedProject](
	[CompletedProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) NULL,
	[ContractDate] [date] NULL,
	[WarrantyExpiredDate] [date] NULL,
	[PGExpiredDate] [date] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_CompletedProject] PRIMARY KEY CLUSTERED 
(
	[CompletedProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CostEstimationCommittee]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostEstimationCommittee](
	[CostEstimationCommitteeId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[CostEstimationCommitteeMemberId] [int] NULL,
	[CostEstimationCommitteeOpeningDate] [date] NULL,
	[EstimatedCost] [decimal](18, 0) NULL,
	[CostEstimationCommitteeAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CostEstimationCommitteeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CostEstimationCommitteeMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostEstimationCommitteeMember](
	[CostEstimationCommitteeMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
	[CostEstimationCommitteeMemberCreateDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[CostEstimationCommitteeMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DefectWithingWarranty]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DefectWithingWarranty](
	[DefectWithingWarrantyId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[ProductId] [int] NULL,
	[InformDate] [date] NULL,
	[SupportStart] [date] NULL,
	[SupportEnd] [date] NULL,
	[SupportStatus] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[DefectWithingWarrantyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[DesignationId] [int] IDENTITY(1,1) NOT NULL,
	[DesignationName] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DesignationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evalution]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evalution](
	[EvalutionId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[EvalutionMeetingDate] [date] NULL,
	[EvalutionMeetingMinutes] [nvarchar](max) NULL,
	[EvalutionReport] [nvarchar](max) NULL,
	[BuySellPropose] [nvarchar](max) NULL,
	[FinalContractPrice] [decimal](18, 0) NULL,
	[EvalutionAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EvalutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EvalutionCommitteemember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EvalutionCommitteemember](
	[EvalutionCommitteememberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EvalutionCommitteememberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacMember](
	[FacMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FacMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FinalAcceptance]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FinalAcceptance](
	[FinalAcceptanceId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[ProductId] [int] NULL,
	[FinalAcceptanceStatus] [varchar](100) NULL,
	[FinalAcceptanceDate] [date] NULL,
	[FacMemberId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FinalAcceptanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinalApproval]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FinalApproval](
	[FinalApprovalId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[ApprovedDate] [date] NULL,
	[UserId] [int] NULL,
	[FinalApprovalAttachment] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[FinalApprovalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FinalContract]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalContract](
	[FinalContractId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[FinalContractPrice] [decimal](18, 0) NULL,
	[ContractOpeningDate] [date] NULL,
	[FinalContractAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[FinalContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ForceRank]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ForceRank](
	[ForceRankId] [int] IDENTITY(1,1) NOT NULL,
	[ForceRankName] [nvarchar](200) NOT NULL,
	[RankTypeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ForceRankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InitialNotesheet]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InitialNotesheet](
	[InitialNotesheetId] [int] IDENTITY(1,1) NOT NULL,
	[InitialNoteSheetOpeningDate] [date] NULL,
	[InitialNotesheetSubject] [nvarchar](max) NULL,
	[InitialNotesheetAttachment] [nvarchar](max) NULL,
	[ProjectId] [int] NULL,
	[VendorId] [int] NULL,
 CONSTRAINT [PK__InitialN__6362C91B8217DD0E] PRIMARY KEY CLUSTERED 
(
	[InitialNotesheetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvitationForTender]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvitationForTender](
	[InvitationForTenderId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[VendorId] [int] NULL,
	[InvitationForTenderDate] [date] NULL,
	[InvitationForTenderAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[InvitationForTenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LC]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LC](
	[LCId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[LCOpeningDate] [date] NULL,
	[NominatedBank] [nvarchar](100) NULL,
	[PaymentProcess] [nvarchar](100) NULL,
	[LCAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[LCId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NOA]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOA](
	[NoaId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[NoaCode] [nvarchar](max) NULL,
	[PGDate] [date] NULL,
	[FinalContatractPrice] [decimal](18, 0) NULL,
	[TenderNo] [nvarchar](max) NULL,
	[NoaAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[NoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoaAcceptance]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoaAcceptance](
	[NoaAcceptanceId] [int] IDENTITY(1,1) NOT NULL,
	[NoaId] [int] NULL,
	[VendorReply] [nvarchar](max) NULL,
	[NoaAcceptanceDate] [date] NULL,
	[NoaAcceptanceAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[NoaAcceptanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PacMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PacMember](
	[PacMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PacMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PGD]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PGD](
	[PgdId] [int] IDENTITY(1,1) NOT NULL,
	[PgdName] [nvarchar](100) NOT NULL,
	[PgdDate] [date] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PgdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PGDWithProduct]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PGDWithProduct](
	[PGDWithProductId] [int] IDENTITY(1,1) NOT NULL,
	[PgdId] [int] NULL,
	[ProductId] [int] NULL,
	[ProductAmount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PGDWithProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PgVerification]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PgVerification](
	[PgVerificationId] [int] IDENTITY(1,1) NOT NULL,
	[NoaId] [int] NULL,
	[PgVerificationStatus] [int] NULL,
	[PgPrice] [decimal](18, 0) NULL,
	[PgOpeningDate] [date] NULL,
	[PgExpireDate] [date] NULL,
	[PgVerificationAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PgVerificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PI]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PI](
	[PiId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[Pidate] [date] NULL,
	[PiAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PO]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PO](
	[POId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[PODate] [date] NULL,
	[POAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[POId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[ProductBrand] [nvarchar](20) NOT NULL,
	[ProductOrigin] [nvarchar](100) NULL,
	[ProductTechSpec] [nvarchar](max) NULL,
	[ProductPrice] [decimal](18, 0) NULL,
	[ProductWarranty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) NOT NULL,
	[ProjectInitialBudget] [decimal](18, 0) NULL,
	[ProjectFinalBudget] [decimal](18, 0) NULL,
	[ProjectStartDate] [date] NOT NULL,
	[ProjectEndDate] [date] NULL,
	[ProjectDescription] [nvarchar](max) NULL,
	[ProjectAttachment] [nvarchar](max) NULL,
	[BureauId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectDetail]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectDetail](
	[ProjectDetailId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[UserId] [int] NULL,
	[VendorId] [int] NULL,
	[PGDWithProductId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectUser]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectUser](
	[ProjectUserId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[BureauId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProjectUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProvisionalAcceptance]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProvisionalAcceptance](
	[ProvisionalAcceptanceId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[ProductId] [int] NULL,
	[AcceptanceStatus] [varchar](100) NULL,
	[ProvisionalAcceptance] [date] NULL,
	[PacMemberId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProvisionalAcceptanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Psi]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Psi](
	[PsiId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[PsiLocation] [nvarchar](100) NULL,
	[PsiStartDate] [date] NULL,
	[PsiEndDate] [date] NULL,
	[PsiDuration] [int] NULL,
	[PsiAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PsiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PsiMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PsiMember](
	[PsiMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
	[PsiMemberCreateDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PsiMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RankType]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RankType](
	[RankTypeId] [int] IDENTITY(1,1) NOT NULL,
	[RankTypeName] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RankTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shipment]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment](
	[ShipmentId] [int] IDENTITY(1,1) NOT NULL,
	[ShipmentName] [nvarchar](200) NULL,
	[ProjectId] [int] NULL,
	[ShipmentReceivedDate] [date] NULL,
	[UserId] [int] NULL,
	[ShipmentFromCountry] [nvarchar](100) NULL,
	[ShipmentAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShipmentItem]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShipmentItem](
	[ShipmentItemId] [int] IDENTITY(1,1) NOT NULL,
	[ShipmentId] [int] NULL,
	[ProductId] [int] NULL,
	[ShipmentItemStatus] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipmentItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TechSpecCommittee]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechSpecCommittee](
	[TechSpecCommitteeId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[TechSpecCommitteeMemberId] [int] NULL,
	[TechSpecCommitteeAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TechSpecCommitteeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TechSpecCommitteeMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechSpecCommitteeMember](
	[TechSpecCommitteeMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TechSpecCommitteeMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TenderOpening]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TenderOpening](
	[TenderOpeningId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[TenderOpeningDate] [date] NULL,
	[TenderClosingDate] [date] NULL,
	[TenderHonorium] [decimal](18, 0) NULL,
	[TenderOpeningAttachment] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenderOpeningId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Training]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Training](
	[TrainingId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[TrainingMemberId] [int] NULL,
	[TrainingLocation] [nvarchar](100) NULL,
	[TrainingStartDate] [date] NULL,
	[TrainingEndDate] [date] NULL,
	[TrainingDuration] [int] NULL,
	[TrainingTaDa] [decimal](18, 0) NULL,
	[TrainingAttachment] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrainingMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrainingMember](
	[TrainingMemberId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ProjectId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TrainingMemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInformation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInformation](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[DesignationId] [int] NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[UserEmail] [nvarchar](max) NOT NULL,
	[UserRoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[LoginId] [int] NOT NULL,
	[UserId] [int] NULL,
	[UserDgfiId] [int] NULL,
	[UserPassword] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserRoleId] [int] IDENTITY(1,1) NOT NULL,
	[UserRoleName] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorContactPersonDesignation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorContactPersonDesignation](
	[VendorContactPersonDesignationId] [int] IDENTITY(1,1) NOT NULL,
	[VendorContactPersonDesignationName] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorContactPersonDesignationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorContactPersonInformation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorContactPersonInformation](
	[VendorContactPersonInformationId] [int] IDENTITY(1,1) NOT NULL,
	[VendorContactPersonName] [nvarchar](200) NOT NULL,
	[VendorId] [int] NOT NULL,
	[VendorContactPersonDesignationId] [int] NOT NULL,
	[VendorContactPersonEmail] [nvarchar](max) NOT NULL,
	[VendorContactPersonPhone] [nvarchar](20) NOT NULL,
	[VendorContactPersonNid] [int] NOT NULL,
	[VendorContactPersonImage] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorContactPersonInformationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendorInformation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendorInformation](
	[VendorId] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](max) NOT NULL,
	[VendorTradeLicenceNo] [nvarchar](max) NOT NULL,
	[VendorEmail] [nvarchar](max) NOT NULL,
	[VendorPhone] [nvarchar](20) NOT NULL,
	[VendorClearence] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warranty]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warranty](
	[WarrantyId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NULL,
	[ProductId] [int] NULL,
	[WarrantyStart] [date] NULL,
	[WarrantyEnd] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[WarrantyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bureau] ON 

INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (1, N'SIB', N'Signal Intelligence Bureau ')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (2, N'CIB', N'Counter Intelligence Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (3, N'CTIB', N'Counter Terrorism Intelligence Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (4, N'IAB', N'Internal Affairs Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (5, N'RDB', N'Research & Development Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (6, N'PPMB', N'Press Publication & Media Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (7, N'PRMC', N'Public Relation & Media Cell')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (8, N'EALB', N'External Affairs & Liaison Bureau')
INSERT [dbo].[Bureau] ([BureauId], [BureauName], [BureauFullName]) VALUES (1002, N'AB', N'Admin Bureau')
SET IDENTITY_INSERT [dbo].[Bureau] OFF
SET IDENTITY_INSERT [dbo].[CompletedProject] ON 

INSERT [dbo].[CompletedProject] ([CompletedProjectId], [ProjectName], [ContractDate], [WarrantyExpiredDate], [PGExpiredDate], [Description]) VALUES (4, N'test', CAST(N'2021-09-30' AS Date), CAST(N'2021-10-30' AS Date), CAST(N'2021-11-02' AS Date), N'test demo')
SET IDENTITY_INSERT [dbo].[CompletedProject] OFF
SET IDENTITY_INSERT [dbo].[Designation] ON 

INSERT [dbo].[Designation] ([DesignationId], [DesignationName]) VALUES (1, N'Sr. System Analyst')
INSERT [dbo].[Designation] ([DesignationId], [DesignationName]) VALUES (2, N'System Analyst')
INSERT [dbo].[Designation] ([DesignationId], [DesignationName]) VALUES (3, N'Asst. System Analyst')
INSERT [dbo].[Designation] ([DesignationId], [DesignationName]) VALUES (4, N'Programmer')
INSERT [dbo].[Designation] ([DesignationId], [DesignationName]) VALUES (5, N'Asst. Programmer')
SET IDENTITY_INSERT [dbo].[Designation] OFF
SET IDENTITY_INSERT [dbo].[FinalApproval] ON 

INSERT [dbo].[FinalApproval] ([FinalApprovalId], [ProjectId], [ApprovedDate], [UserId], [FinalApprovalAttachment]) VALUES (1, 1006, CAST(N'2020-11-04' AS Date), 1, N'm_2021118165245.jpeg')
SET IDENTITY_INSERT [dbo].[FinalApproval] OFF
SET IDENTITY_INSERT [dbo].[ForceRank] ON 

INSERT [dbo].[ForceRank] ([ForceRankId], [ForceRankName], [RankTypeId]) VALUES (1, N'Colonel', 1)
INSERT [dbo].[ForceRank] ([ForceRankId], [ForceRankName], [RankTypeId]) VALUES (2, N'Lt Colonel', 2)
SET IDENTITY_INSERT [dbo].[ForceRank] OFF
SET IDENTITY_INSERT [dbo].[InitialNotesheet] ON 

INSERT [dbo].[InitialNotesheet] ([InitialNotesheetId], [InitialNoteSheetOpeningDate], [InitialNotesheetSubject], [InitialNotesheetAttachment], [ProjectId], [VendorId]) VALUES (1, CAST(N'2021-10-17' AS Date), N'demo', N'BD MSN Forms_2021101713285.pdf', 1006, 1)
SET IDENTITY_INSERT [dbo].[InitialNotesheet] OFF
SET IDENTITY_INSERT [dbo].[InvitationForTender] ON 

INSERT [dbo].[InvitationForTender] ([InvitationForTenderId], [ProjectId], [VendorId], [InvitationForTenderDate], [InvitationForTenderAttachment]) VALUES (1, 1006, 1, CAST(N'2021-10-04' AS Date), N'TransitSlip (9)_20211018132728.pdf')
SET IDENTITY_INSERT [dbo].[InvitationForTender] OFF
SET IDENTITY_INSERT [dbo].[LC] ON 

INSERT [dbo].[LC] ([LCId], [ProjectId], [LCOpeningDate], [NominatedBank], [PaymentProcess], [LCAttachment]) VALUES (1, 1007, CAST(N'2021-12-06' AS Date), N'Bangladesh Bank', N'Cash', NULL)
INSERT [dbo].[LC] ([LCId], [ProjectId], [LCOpeningDate], [NominatedBank], [PaymentProcess], [LCAttachment]) VALUES (2, 1006, CAST(N'2021-11-09' AS Date), N'EBL', N'80%', N'Annexure_20211116122721.pdf')
SET IDENTITY_INSERT [dbo].[LC] OFF
SET IDENTITY_INSERT [dbo].[NOA] ON 

INSERT [dbo].[NOA] ([NoaId], [ProjectId], [NoaCode], [PGDate], [FinalContatractPrice], [TenderNo], [NoaAttachment]) VALUES (1, 1006, N'N-12345', CAST(N'2021-12-10' AS Date), CAST(89000 AS Decimal(18, 0)), N'LC-000135', NULL)
INSERT [dbo].[NOA] ([NoaId], [ProjectId], [NoaCode], [PGDate], [FinalContatractPrice], [TenderNo], [NoaAttachment]) VALUES (2, 1005, N'n-2314', CAST(N'2021-11-15' AS Date), CAST(500000000 AS Decimal(18, 0)), N'tn 6500', N'TransitSlip_20211115104734.pdf')
SET IDENTITY_INSERT [dbo].[NOA] OFF
SET IDENTITY_INSERT [dbo].[PgVerification] ON 

INSERT [dbo].[PgVerification] ([PgVerificationId], [NoaId], [PgVerificationStatus], [PgPrice], [PgOpeningDate], [PgExpireDate], [PgVerificationAttachment]) VALUES (1, 2, 0, CAST(50000 AS Decimal(18, 0)), CAST(N'2021-11-18' AS Date), CAST(N'2021-11-17' AS Date), N'TransitSlip_2021111815495.pdf')
SET IDENTITY_INSERT [dbo].[PgVerification] OFF
SET IDENTITY_INSERT [dbo].[PI] ON 

INSERT [dbo].[PI] ([PiId], [ProjectId], [Pidate], [PiAttachment]) VALUES (1, 1007, CAST(N'2019-11-08' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[PI] OFF
SET IDENTITY_INSERT [dbo].[PO] ON 

INSERT [dbo].[PO] ([POId], [ProjectId], [PODate], [POAttachment]) VALUES (1, 1005, CAST(N'2021-11-10' AS Date), N'TransitSlip (20)_2021111016512.pdf')
SET IDENTITY_INSERT [dbo].[PO] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([ProjectId], [ProjectName], [ProjectInitialBudget], [ProjectFinalBudget], [ProjectStartDate], [ProjectEndDate], [ProjectDescription], [ProjectAttachment], [BureauId]) VALUES (1005, N'demo', CAST(100000 AS Decimal(18, 0)), CAST(200000 AS Decimal(18, 0)), CAST(N'2021-10-14' AS Date), CAST(N'2021-10-12' AS Date), N'Na', N'ProjectFileAttachment__20211014154532_BD MSN Forms.pdf', 1)
INSERT [dbo].[Project] ([ProjectId], [ProjectName], [ProjectInitialBudget], [ProjectFinalBudget], [ProjectStartDate], [ProjectEndDate], [ProjectDescription], [ProjectAttachment], [BureauId]) VALUES (1006, N'CDMS', CAST(200000 AS Decimal(18, 0)), CAST(25000 AS Decimal(18, 0)), CAST(N'2019-01-01' AS Date), CAST(N'2023-01-01' AS Date), N'test', N'TransitSlip (21)_20211017132236.pdf', 1)
INSERT [dbo].[Project] ([ProjectId], [ProjectName], [ProjectInitialBudget], [ProjectFinalBudget], [ProjectStartDate], [ProjectEndDate], [ProjectDescription], [ProjectAttachment], [BureauId]) VALUES (1007, N'Project Nov-14', CAST(125000 AS Decimal(18, 0)), CAST(198000 AS Decimal(18, 0)), CAST(N'2021-11-14' AS Date), CAST(N'2023-11-13' AS Date), N'Demo Test Project', N'NAINUWA_Features_20190403_v01_20211114144749.pdf', 8)
SET IDENTITY_INSERT [dbo].[Project] OFF
SET IDENTITY_INSERT [dbo].[Psi] ON 

INSERT [dbo].[Psi] ([PsiId], [ProjectId], [PsiLocation], [PsiStartDate], [PsiEndDate], [PsiDuration], [PsiAttachment]) VALUES (1, 1006, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Psi] ([PsiId], [ProjectId], [PsiLocation], [PsiStartDate], [PsiEndDate], [PsiDuration], [PsiAttachment]) VALUES (2, 1006, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Psi] OFF
SET IDENTITY_INSERT [dbo].[RankType] ON 

INSERT [dbo].[RankType] ([RankTypeId], [RankTypeName]) VALUES (1, N'Bangladesh Army')
INSERT [dbo].[RankType] ([RankTypeId], [RankTypeName]) VALUES (2, N'Bangladesh Air Force')
INSERT [dbo].[RankType] ([RankTypeId], [RankTypeName]) VALUES (3, N'Bangladesh Navy')
SET IDENTITY_INSERT [dbo].[RankType] OFF
SET IDENTITY_INSERT [dbo].[TenderOpening] ON 

INSERT [dbo].[TenderOpening] ([TenderOpeningId], [ProjectId], [TenderOpeningDate], [TenderClosingDate], [TenderHonorium], [TenderOpeningAttachment]) VALUES (1, 1005, CAST(N'2021-10-17' AS Date), CAST(N'2021-10-24' AS Date), CAST(30000 AS Decimal(18, 0)), N'BANGLADESH IN GLOBAL PERSPECTIVE 11102021_20211024161329.docx')
SET IDENTITY_INSERT [dbo].[TenderOpening] OFF
SET IDENTITY_INSERT [dbo].[UserInformation] ON 

INSERT [dbo].[UserInformation] ([UserId], [UserName], [DesignationId], [PhoneNumber], [UserEmail], [UserRoleId]) VALUES (1, N'Mehedi', 5, N'01234567889', N'ito.mehedi@gmail.com', 4)
SET IDENTITY_INSERT [dbo].[UserInformation] OFF
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (1, N'Super Admin')
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (2, N'Admin')
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (3, N'Project Co-Ordinator')
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (4, N'Project Officer')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[VendorInformation] ON 

INSERT [dbo].[VendorInformation] ([VendorId], [VendorName], [VendorTradeLicenceNo], [VendorEmail], [VendorPhone], [VendorClearence]) VALUES (1, N'Priyo', N'123456', N'p@gamil.com', N'017232232', N'ok')
SET IDENTITY_INSERT [dbo].[VendorInformation] OFF
ALTER TABLE [dbo].[CostEstimationCommittee]  WITH CHECK ADD FOREIGN KEY([CostEstimationCommitteeMemberId])
REFERENCES [dbo].[CostEstimationCommitteeMember] ([CostEstimationCommitteeMemberId])
GO
ALTER TABLE [dbo].[CostEstimationCommittee]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[CostEstimationCommitteeMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[CostEstimationCommitteeMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[DefectWithingWarranty]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[DefectWithingWarranty]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Evalution]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[EvalutionCommitteemember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[EvalutionCommitteemember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[FacMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[FacMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[FinalAcceptance]  WITH CHECK ADD FOREIGN KEY([FacMemberId])
REFERENCES [dbo].[FacMember] ([FacMemberId])
GO
ALTER TABLE [dbo].[FinalAcceptance]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[FinalAcceptance]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[FinalApproval]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[FinalApproval]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[FinalContract]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[ForceRank]  WITH CHECK ADD FOREIGN KEY([RankTypeId])
REFERENCES [dbo].[RankType] ([RankTypeId])
GO
ALTER TABLE [dbo].[InitialNotesheet]  WITH CHECK ADD  CONSTRAINT [FK__InitialNo__Proje__3C69FB99] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[InitialNotesheet] CHECK CONSTRAINT [FK__InitialNo__Proje__3C69FB99]
GO
ALTER TABLE [dbo].[InitialNotesheet]  WITH CHECK ADD  CONSTRAINT [FK__InitialNo__Vendo__3D5E1FD2] FOREIGN KEY([VendorId])
REFERENCES [dbo].[VendorInformation] ([VendorId])
GO
ALTER TABLE [dbo].[InitialNotesheet] CHECK CONSTRAINT [FK__InitialNo__Vendo__3D5E1FD2]
GO
ALTER TABLE [dbo].[InvitationForTender]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[InvitationForTender]  WITH CHECK ADD FOREIGN KEY([VendorId])
REFERENCES [dbo].[VendorInformation] ([VendorId])
GO
ALTER TABLE [dbo].[LC]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[NOA]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[NoaAcceptance]  WITH CHECK ADD FOREIGN KEY([NoaId])
REFERENCES [dbo].[NOA] ([NoaId])
GO
ALTER TABLE [dbo].[PacMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[PacMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[PGD]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[PGDWithProduct]  WITH CHECK ADD FOREIGN KEY([PgdId])
REFERENCES [dbo].[PGD] ([PgdId])
GO
ALTER TABLE [dbo].[PGDWithProduct]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[PgVerification]  WITH CHECK ADD FOREIGN KEY([NoaId])
REFERENCES [dbo].[NOA] ([NoaId])
GO
ALTER TABLE [dbo].[PI]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[PO]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD FOREIGN KEY([BureauId])
REFERENCES [dbo].[Bureau] ([BureauId])
GO
ALTER TABLE [dbo].[ProjectDetail]  WITH CHECK ADD FOREIGN KEY([PGDWithProductId])
REFERENCES [dbo].[PGDWithProduct] ([PGDWithProductId])
GO
ALTER TABLE [dbo].[ProjectDetail]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[ProjectDetail]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[ProjectDetail]  WITH CHECK ADD FOREIGN KEY([VendorId])
REFERENCES [dbo].[VendorInformation] ([VendorId])
GO
ALTER TABLE [dbo].[ProjectUser]  WITH CHECK ADD FOREIGN KEY([BureauId])
REFERENCES [dbo].[Bureau] ([BureauId])
GO
ALTER TABLE [dbo].[ProjectUser]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[ProvisionalAcceptance]  WITH CHECK ADD FOREIGN KEY([PacMemberId])
REFERENCES [dbo].[PacMember] ([PacMemberId])
GO
ALTER TABLE [dbo].[ProvisionalAcceptance]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[ProvisionalAcceptance]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Psi]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[PsiMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[PsiMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[ShipmentItem]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[ShipmentItem]  WITH CHECK ADD FOREIGN KEY([ShipmentId])
REFERENCES [dbo].[Shipment] ([ShipmentId])
GO
ALTER TABLE [dbo].[TechSpecCommittee]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[TechSpecCommittee]  WITH CHECK ADD FOREIGN KEY([TechSpecCommitteeMemberId])
REFERENCES [dbo].[TechSpecCommitteeMember] ([TechSpecCommitteeMemberId])
GO
ALTER TABLE [dbo].[TechSpecCommitteeMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[TechSpecCommitteeMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[TenderOpening]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD FOREIGN KEY([TrainingMemberId])
REFERENCES [dbo].[TrainingMember] ([TrainingMemberId])
GO
ALTER TABLE [dbo].[TrainingMember]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
ALTER TABLE [dbo].[TrainingMember]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[UserInformation]  WITH CHECK ADD FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designation] ([DesignationId])
GO
ALTER TABLE [dbo].[UserInformation]  WITH CHECK ADD FOREIGN KEY([UserRoleId])
REFERENCES [dbo].[UserRole] ([UserRoleId])
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD  CONSTRAINT [FK_UserLogin_UserInformation] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserInformation] ([UserId])
GO
ALTER TABLE [dbo].[UserLogin] CHECK CONSTRAINT [FK_UserLogin_UserInformation]
GO
ALTER TABLE [dbo].[VendorContactPersonInformation]  WITH CHECK ADD FOREIGN KEY([VendorId])
REFERENCES [dbo].[VendorInformation] ([VendorId])
GO
ALTER TABLE [dbo].[VendorContactPersonInformation]  WITH CHECK ADD FOREIGN KEY([VendorContactPersonDesignationId])
REFERENCES [dbo].[VendorContactPersonDesignation] ([VendorContactPersonDesignationId])
GO
ALTER TABLE [dbo].[Warranty]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[Warranty]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
GO
/****** Object:  StoredProcedure [dbo].[SpGetAllPO]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetAllPO]
as
begin
select p.POId, p.PODate,p.ProjectId, p.POAttachment from PO as p
end

GO
/****** Object:  StoredProcedure [dbo].[SpGetAllRankType]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetAllRankType]
as
begin
select * from RankType
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetAllTenderOpening]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetAllTenderOpening]
as
begin
select * from TenderOpening
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetAllTenderOpeningById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetAllTenderOpeningById]
@TenderOpeningId int
as
begin
select * from TenderOpening where TenderOpeningId=@TenderOpeningId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetBureau]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetBureau]
as
begin
select * from Bureau
end


GO
/****** Object:  StoredProcedure [dbo].[SpGetBureauById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetBureauById]
@BureauId int
as
begin
select b.BureauId,b.BureauName,b.BureauFullName from Bureau as b where b.BureauId= @BureauId 
end
GO
/****** Object:  StoredProcedure [dbo].[SPGetDesignation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPGetDesignation]
as
begin
select * from Designation
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetDivisionById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpGetDivisionById]

@DesignationId int
as
begin 
select DesignationId, DesignationName from Designation where DesignationId=@DesignationId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetFinalApproval]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetFinalApproval]
as
begin
select * from FinalApproval
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetFinalApprovalById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpGetFinalApprovalById]
@FinalApprovalId int
as
begin
select FinalApprovalId, ProjectId, ApprovedDate, UserId, FinalApprovalAttachment from FinalApproval where  FinalApprovalId=@FinalApprovalId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetForceRank]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpGetForceRank]
as
begin
select fr.ForceRankId, fr.ForceRankName,fr.RankTypeId, rt.RankTypeName from ForceRank as fr left join RankType as rt on fr.RankTypeId=rt.RankTypeId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetForceRankById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetForceRankById]
@ForceRankId int
as
begin
select fr.ForceRankId,fr.ForceRankName,fr.RankTypeId from ForceRank as fr where fr.ForceRankId=@ForceRankId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetInitialNoteSheet]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetInitialNoteSheet]
as
begin
select *from InitialNotesheet
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetInitialNoteSheetById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetInitialNoteSheetById]
@InitialNotesheetId int
as
begin
select *from InitialNotesheet where InitialNotesheetId=@InitialNotesheetId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetInvitaionForTendar]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetInvitaionForTendar]
as
begin
select * from InvitationForTender
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetInvitaionForTendarById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetInvitaionForTendarById]
@InvitationForTenderId int
as
begin
select * from InvitationForTender where InvitationForTender.InvitationForTenderId= @InvitationForTenderId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetLC]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE PROCEDURE [dbo].[SpGetLC] as
begin
SELECT [LCId]
      ,[ProjectId]
      ,[LCOpeningDate]
      ,[NominatedBank]
      ,[PaymentProcess]
      ,[LCAttachment]
  FROM [ProjectManagementDB].[dbo].[LC]
  end

GO
/****** Object:  StoredProcedure [dbo].[SpGetLCById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE PROCEDURE [dbo].[SpGetLCById] @id int as
begin
SELECT *
  FROM [ProjectManagementDB].[dbo].[LC] 
  WHERE LCId = @id
  end

GO
/****** Object:  StoredProcedure [dbo].[SpGetNoa]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpGetNoa] as
begin
SELECT [NoaId]
      ,[ProjectId]
      ,[NoaCode]
      ,[PGDate]
      ,[FinalContatractPrice]
      ,[TenderNo]
      ,[NoaAttachment]
  FROM [ProjectManagementDB].[dbo].[NOA]
  end

GO
/****** Object:  StoredProcedure [dbo].[SpGetNoaById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SpGetNoaById]
@NoaId int
as
begin
select * from NOA where NoaId=@NoaId
end

GO
/****** Object:  StoredProcedure [dbo].[SpgetPGVerification]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpgetPGVerification]
as
begin
select p.PgVerificationId,p.PgPrice,p.PgOpeningDate,p.PgExpireDate,p.PgVerificationStatus,p.PgVerificationAttachment,p.NoaId from PgVerification as p
end
GO
/****** Object:  StoredProcedure [dbo].[SpgetPGVerificationById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpgetPGVerificationById]
@PgVerificationId int
as
begin
select p.PgVerificationId,p.PgPrice,p.PgOpeningDate,p.PgExpireDate,p.PgVerificationStatus,p.PgVerificationAttachment,p.NoaId from PgVerification as p where p.PgVerificationId=@PgVerificationId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetPI]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
CREATE PROCEDURE [dbo].[SpGetPI] AS
SELECT [PiId]
      ,[ProjectId]
      ,[Pidate]
      ,[PiAttachment]
  FROM [ProjectManagementDB].[dbo].[PI];
GO
/****** Object:  StoredProcedure [dbo].[SpGetPIById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Script for SelectTopNRows command from SSMS  ******/
create procedure [dbo].[SpGetPIById]
@PiId int
as
begin
select * from PI where PiId=PiId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetPOById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetPOById]
@POId int
as
begin
select p.POId, p.PODate,p.ProjectId, p.POAttachment from PO as p where p.POId=@POId
end

GO
/****** Object:  StoredProcedure [dbo].[SpGetProject]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpGetProject]
as
begin
select * from Project
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetProjectById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetProjectById]
@ProjectId int
as 
begin
select * from Project where ProjectId= @ProjectId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetPsiMember]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SpGetPsiMember]
as
begin
select p.PsiMemberId, p.ProjectId,p.UserId,p.PsiMemberCreateDate from PsiMember as p
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetPsiMemberById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SpGetPsiMemberById]
@PsiMemberId int
as
begin
select p.PsiMemberId, p.ProjectId,p.UserId,p.PsiMemberCreateDate from PsiMember as p where p.PsiMemberId=@PsiMemberId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetRankTypeById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetRankTypeById]
@RankTypeId int
as
begin
select RankTypeId, RankTypeName from RankType where RankTypeId= @RankTypeId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetUserById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetUserById]
@UserId int
as
begin
select u.UserId, u.UserName, u.UserEmail, u.PhoneNumber,u.DesignationId,u.UserRoleId from UserInformation as u
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetUserList]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetUserList]
as
begin
select u.UserId, u.UserName, u.UserEmail, u.PhoneNumber,u.DesignationId,u.UserRoleId from UserInformation as u
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetUserRole]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetUserRole]
as
begin
select ur.UserRoleId, ur.UserRoleName from UserRole as ur
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetUserRoleById]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SpGetUserRoleById]
@UserRoleId int
as
begin
select ur.UserRoleId, ur.UserRoleName from UserRole as ur where ur.UserRoleId=@UserRoleId
end
GO
/****** Object:  StoredProcedure [dbo].[SpGetVendorInformation]    Script Date: 25-Nov-21 4:16:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpGetVendorInformation]
as
begin
select * from VendorInformation
end
GO
