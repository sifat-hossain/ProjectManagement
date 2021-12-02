using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface ILC
    {
        Task<List<LcViewModel>> Details();
        Task<string> Create(LcViewModel viewModel);
    }
}
