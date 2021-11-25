using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IPGVerification
    {
        Task<List<PgVerificationViewModel>> GetAllPgVerification();
        Task<string> CreatePgVerification(PgVerificationViewModel pgVerificationViewModel);
        PgVerificationViewModel GetPgVerificationById(int? id);
        Task<string> UpdatePgVerification(PgVerificationViewModel pgVerificationViewModel);
    }
}
