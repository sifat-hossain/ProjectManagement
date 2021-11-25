using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface IUserRole
    {
        Task<List<UserRoleViewModel>> GetAllUserRole();
        Task<string> CreateUserRole(UserRoleViewModel userRoleViewModel);
      UserRoleViewModel GetUserRoleById(int? id);
        Task<string> UpdateUserRole(UserRoleViewModel userRoleViewModel);
    }
}
