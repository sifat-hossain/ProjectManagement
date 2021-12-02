using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IProject
    {
        Task<List<ProjectViewModel>> GetAllProject();
        Task<string> CreateProject(ProjectViewModel projectViewModel, IFormFile ProjectAttachment);
      Task<ProjectViewModel> GetProjectById(int? id);
        Task<string> UpdateProject(ProjectViewModel projectViewModel);
    }
}
