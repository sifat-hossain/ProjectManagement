using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IForceRank
    {
       Task<List<ForceRankViewModel>> GetAllForceRank();
        Task<string> CreateForceRank(ForceRankViewModel forceRankViewModel);
        ForceRankViewModel GetForceRankById(int? id);
        Task<string> UpdateForceRank(ForceRankViewModel forceRankViewModel);
    }
}
