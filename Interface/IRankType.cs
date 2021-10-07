using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface IRankType
    {
        Task<List<RankTypeViewModel>> GetAllRankType();
        Task<string> CreateRankType(RankTypeViewModel rankTypeViewModel);
        RankTypeViewModel GetRankTypeById(int? id);
        Task<string> UpdateRankType(RankTypeViewModel rankTypeViewModel);
    }
}
