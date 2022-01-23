using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface ITenderOpening
    {
        Task<List<TenderOpeningViewModel>> GetAllTenderOpening();
        Task<List<TenderOpeningViewModel>> GetTenderOpeningByProjectId(int? ProjectId);
        Task<string> CreateTenderOpening(TenderOpeningViewModel tenderOpeningViewModel, IFormFile tenderOpeningAttachment);
        TenderOpeningViewModel GetTenderOpeningById(int? id);
        Task<string> UpdateTenderOpening(TenderOpeningViewModel tenderOpeningViewModel);
    }
}
