using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class UserRoleServiceLayer : IUserRole
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public UserRoleServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreateUserRole(UserRoleViewModel userRoleViewModel)
        {
            if (userRoleViewModel == null)
            {
                throw new NullReferenceException();
            }
            string result;
            UserRole userRole = mapper.Map<UserRole>(userRoleViewModel);
            await dbContext.UserRoles.AddAsync(userRole);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created The New User Role";
            }
            catch (DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<UserRoleViewModel>> GetAllUserRole()
        {
            List<UserRole> userRole = await dbContext.UserRoles.FromSqlRaw("exec SpGetUserRole").ToListAsync();
            List<UserRoleViewModel> userRoleViewModel = mapper.Map<List<UserRoleViewModel>>(userRole);
            return userRoleViewModel;
        }

        public UserRoleViewModel GetUserRoleById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            try
            {
                UserRole userRole =  dbContext.UserRoles.FromSqlRaw("exec SpGetUserRoleById {0}", id).ToList().FirstOrDefault();
                UserRoleViewModel userRoleViewModel =  mapper.Map<UserRoleViewModel>(userRole);
                return userRoleViewModel;
            }
            catch
            {
                throw;
            }

        }

        public async Task<string> UpdateUserRole(UserRoleViewModel userRoleViewModel)
        {

            string result;
            if(userRoleViewModel==null)
            {
                throw new NullReferenceException();
            }
            UserRole userRole = mapper.Map<UserRole>(userRoleViewModel);
              dbContext.UserRoles.Update(userRole);

            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Updated The User Role";
            }
            catch (DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

     
    }
}
