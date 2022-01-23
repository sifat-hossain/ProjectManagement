using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IFinalApproval
    {
        Task<List<FinalApprovalViewModel>> GetAllFinalApproval();
        Task<List<FinalApprovalViewModel>> GetFinalApprovalByProjectId(int? id);
        Task<string> CreateFinalApproval(FinalApprovalViewModel finalApprovalViewModel, IFormFile finalApprovalAttachment);
        FinalApprovalViewModel GetFinalApprovalById(int? id);
        Task<string> UpdateFinalApproval(FinalApprovalViewModel finalApprovalViewModel);
    }
}
