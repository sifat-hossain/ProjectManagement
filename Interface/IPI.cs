using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface IPI
    {
        Task<List<PiViewModel>> GetAllPI();
        Task<List<PiViewModel>> GetPIByProjectId(int? ProjectId);
        Task<string> CreatePI(PiViewModel viewModel);
        /*
PiViewModel GetPIById(int? id);
Task<string> UpdateNoa(PiViewModel viewModel);
*/
    }
}
