using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IPSIMember
    {
        Task<List<PsiMemberViewModel>> GetAllPsimember();
        Task<string> CreatepsiMember(PsiMemberViewModel psiMemberViewModel);
        PsiMemberViewModel GetPsimemberById(int? id);
        Task<string> UpdatePsimember(PsiMemberViewModel psiMemberViewModel);
    }
}
