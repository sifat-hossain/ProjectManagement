using ProjectManagement.Models;
using ProjectManagement.ServiceLayer;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
   public interface IUserInformation
    {
        Task<List<UserInformationViewModel>> GetAllUserInformation();
        Task<string> CreateUser(UserInformationViewModel userInformationViewModel);
        UserInformationViewModel GetUserById(int? id);
        Task<string> UpdateUser(UserInformationViewModel userInformationViewModel);
    }
}
