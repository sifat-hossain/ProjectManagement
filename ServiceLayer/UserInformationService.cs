using AutoMapper;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class UserInformationService : IUserInformation
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public UserInformationService(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public Task<List<UserInformationViewModel>> GetAllUserInformation()
        {
            List<UserInformationViewModel> item =new();
           
            return Task.FromResult(item);
        }
    }
}
