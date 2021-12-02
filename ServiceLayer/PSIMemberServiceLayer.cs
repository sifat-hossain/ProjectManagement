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

        public async Task<List<PsiMemberViewModel>> GetAllPsimember()
        {
            List<PsiMemberViewModel> psiMemberViewModel = new();
            try
            {
                List<PsiMember> psiMember = await dbContext.PsiMembers.FromSqlRaw("exec SpGetPsiMember").ToListAsync();
                foreach(var item in psiMember)
                {
                    var _psiMember = dbContext.PsiMembers.FromSqlRaw("exec SpGetPsiMemberById {0}", item.PsiMemberId).ToList().FirstOrDefault();
                    psiMemberViewModel.Add(await PsiMemberViewModel(_psiMember));
                }
            }
            catch
            {
                throw;
            }
            return psiMemberViewModel;
        }
        public async Task<PsiMemberViewModel> PsiMemberViewModel(PsiMember psiMember)
        {
            PsiMemberViewModel psiM = new();
            List<UserInformation> userInformation = await dbContext.UserInformations.FromSqlRaw("exec SpGetUserList").ToListAsync();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();

            psiM.PsiMemberId = psiMember.PsiMemberId;
            psiM.UserName = userInformation.Where(x => x.UserId == psiMember.UserId).FirstOrDefault().UserName;
            psiM.ProjectName = project.Where(x => x.ProjectId == psiMember.ProjectId).FirstOrDefault().ProjectName;
            psiM.PsiMemberCreateDate = psiMember.PsiMemberCreateDate;
            return psiM;
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
