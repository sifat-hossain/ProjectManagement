using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IInvitationForTender
    {
        Task<List<InvitationForTenderViewModel>> GetAllInvitationForTender();
        Task<string>CreateInvitationForTender(InvitationForTenderViewModel invitationForTenderViewModel, IFormFile InvitationForTenderAttachment);
        InvitationForTenderViewModel GetInvitationForTenderById(int? id);
        Task<InvitationForTenderViewModel> GetInvitationForTendeByProjectId(int? projectId);
        Task<string>UpdateInvitationForTender(InvitationForTenderViewModel invitationForTenderViewModel);
    }
}
