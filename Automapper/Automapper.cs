using AutoMapper;
using ProjectManagement.DTO;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;

namespace MailSectionEALB.Automapper
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            // CreateMap<UserViewModel, UserInformation>().ReverseMap();
            CreateMap<Designation, DesignationViewModel>().ReverseMap();            
            CreateMap<RankType, RankTypeViewModel>().ReverseMap();
            CreateMap<ForceRank, ForceRankViewModel>().ReverseMap();
            CreateMap<ForceRankDTO, ForceRankViewModel>().ReverseMap();
            CreateMap<VendorInformation, VendorInformationViewModel>().ReverseMap();
            CreateMap<Bureau, BureauViewModel>().ReverseMap();
            CreateMap<Project, ProjectViewModel>().ReverseMap();
            CreateMap<InitialNotesheet, InitialNotesheetViewModel>().ReverseMap();
            CreateMap<InvitationForTender, InvitationForTenderViewModel>().ReverseMap();
           
        }
    }
}
