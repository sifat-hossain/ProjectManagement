using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.DTO;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class UserInformationServiceLayer : IUserInformation
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public UserInformationServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }

        public async Task<string> CreateUser(UserInformationViewModel userInformationViewModel)
        {
            string result;
            if (userInformationViewModel==null)
            {
                throw new Exception();
            }
            UserInformation userInformation = mapper.Map<UserInformation>(userInformationViewModel);
            await dbContext.UserInformations.AddAsync(userInformation);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created a User";
            }
            catch
            {
                throw new DbUpdateException();
            }
            return result;
        }

        public async Task<List<UserInformationViewModel>> GetAllUserInformation()
        {
            List<UserInformationViewModel> userInformationViewModel = new();
            try
            {
                List<UserInformation> userInformation = await dbContext.UserInformations.FromSqlRaw("exec SpGetUserList").ToListAsync();
                foreach(var item in userInformation)
                {
                    var _userInfo = dbContext.UserInformations.FromSqlRaw("exec SpGetUserById {0}", item.UserId).ToList().FirstOrDefault();
                    userInformationViewModel.Add(await UserInformationViewModel(_userInfo));
                }
            }
            catch
            {
                throw;
            }
            return userInformationViewModel; 
        }
        public async Task<UserInformationViewModel> UserInformationViewModel(UserInformation userInformation)
        {
            List<Designation> designation = await dbContext.Designations.FromSqlRaw("exec SpGetDesignation").ToListAsync();
            List<UserRole> userRole = await dbContext.UserRoles.FromSqlRaw("exec SpGetUserRole").ToListAsync();

            UserInformationViewModel user = new();
            user.UserId = userInformation.UserId;
            user.UserName = userInformation.UserName;
            user.UserEmail = userInformation.UserEmail;
            user.PhoneNumber = userInformation.PhoneNumber;
            user.DesignationName = designation.Where(x => x.DesignationId == userInformation.DesignationId).FirstOrDefault().DesignationName;
            user.UserRoleName = userRole.Where(x => x.UserRoleId == userInformation.UserRoleId).FirstOrDefault().UserRoleName;
            
            return user;
        }

        public UserInformationViewModel GetUserById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUser(UserInformationViewModel userInformationViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
