using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IBureau
    {
        Task<List<BureauViewModel>> GetAllBureau();
        Task<string> CreateBureau(BureauViewModel bureauViewModel);
        BureauViewModel GetBureauById(int? id);
        Task<string> UpdateBureau(BureauViewModel bureauViewModel);
    }
}
