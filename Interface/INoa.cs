using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;

namespace ProjectManagement.Interface
{
    public interface INoa
    {
        Task<List<NoaViewModel>> GetAllNoa();
        Task<string> CreateNoa(NoaViewModel noaViewModel, IFormFile noaAttachment);
        NoaViewModel GetNoaById(int? id);
        Task<string> UpdateNoa(NoaViewModel noaViewModel);
    }
}
