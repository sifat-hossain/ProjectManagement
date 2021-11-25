using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface IPO
    {
        Task<List<PoViewModel>> GetAllPO();
        Task<string> CreatePO(PoViewModel poViewModel, IFormFile poAttachment);
        PoViewModel GetPOById(int? id);
        Task<string> UpdatePO(PoViewModel poViewModel);
    }
}
