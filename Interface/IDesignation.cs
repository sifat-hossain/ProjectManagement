using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IDesignation
    {
        Task<List<DesignationViewModel>> GetAllDesignation();
        Task<string> CreateDesignation(DesignationViewModel designationViewModel);
        DesignationViewModel GetDesignationById(int? id);
        Task<string> UpdateDesignation(DesignationViewModel designationViewModel);
    }
}
