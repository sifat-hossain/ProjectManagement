using AutoMapper;
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
    public class PSIMemberServiceLayer : IPSIMember
    {
        public readonly dbContext dbContext;
        public readonly IMapper mapper;
        public PSIMemberServiceLayer(dbContext _dbContext, IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreatepsiMember(PsiMemberViewModel psiMemberViewModel)
        {
            string result;

            if(psiMemberViewModel==null)
            {
                throw new NullReferenceException();
            }
            PsiMember psiMember = mapper.Map<PsiMember>(psiMemberViewModel);
            await dbContext.PsiMembers.AddAsync(psiMember);
            try
            {
                await dbContext.SaveChangesAsync();
                result= "Successfully Created PSI Member List";
            }
            catch(DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

        public Task<List<PsiMemberViewModel>> GetAllPsimember()
        {
            throw new NotImplementedException();
        }

        public PsiMemberViewModel GetPsimemberById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePsimember(PsiMemberViewModel psiMemberViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
