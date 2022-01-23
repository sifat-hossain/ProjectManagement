using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IPSI
    {
        Task<List<PsiViewModel>> GetAllPSI();
        Task<List<PsiViewModel>> GetPsiByProjectId(int? ProjectId);
        Task<string> CreatePSI(PsiViewModel psiViewModel);
        PsiViewModel GetPSIById(int? id);
        Task<string> UpdatePSI(PsiViewModel psiViewModel);
    }
}
