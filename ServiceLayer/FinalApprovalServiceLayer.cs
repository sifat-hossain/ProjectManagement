using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class FinalApprovalServiceLayer : IFinalApproval
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public FinalApprovalServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreateFinalApproval(FinalApprovalViewModel finalApprovalViewModel, IFormFile finalApprovalAttachment)
        {
            string result;
            if (finalApprovalViewModel == null && finalApprovalAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(finalApprovalAttachment.FileName);
                fileExtension = Path.GetExtension(finalApprovalAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/FinalApprovalAttachment", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await finalApprovalAttachment.CopyToAsync(stream);
                stream.Close();
                finalApprovalViewModel.FinalApprovalAttachment = fileName;

            }
            catch

            {
                throw;
            }
            FinalApproval finalApproval = mapper.Map<FinalApproval>(finalApprovalViewModel);
            await dbContext.FinalApprovals.AddAsync(finalApproval);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created The Note Sheet";
            }
            catch(DbUpdateException e)
            {
                result=e.Message;
            }
            return result;
        }

        public async Task<List<FinalApprovalViewModel>> GetAllFinalApproval()
        {
            List<FinalApprovalViewModel> finalApprovalViewModel = new(); 
            try
            {
                List<FinalApproval> finalApproval = await dbContext.FinalApprovals.FromSqlRaw("exec SpGetFinalApproval").ToListAsync();
                foreach (var item in finalApproval)
                {
                    var _finalApproval = dbContext.FinalApprovals.FromSqlRaw("exec SpGetFinalApprovalById {0}", item.FinalApprovalId).ToList().FirstOrDefault();
                   finalApprovalViewModel.Add(await FinalApprovalViewModel(_finalApproval));
                }
            }
            catch
            {
                throw;
            }
            return finalApprovalViewModel;
        }
        public async Task<FinalApprovalViewModel> FinalApprovalViewModel(FinalApproval finalApproval)
        {
            FinalApprovalViewModel fav = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            List<UserInformation> userInformation = await dbContext.UserInformations.FromSqlRaw("exec SpGetUserList").ToListAsync();

            fav.FinalApprovalId = finalApproval.FinalApprovalId;
            fav.ApprovedDate = finalApproval.ApprovedDate;
            fav.FinalApprovalAttachment = finalApproval.FinalApprovalAttachment;
            fav.ProjectName = project.Where(x => x.ProjectId == finalApproval.ProjectId).FirstOrDefault().ProjectName;
            fav.UserName = userInformation.Where(x => x.UserId == finalApproval.UserId).FirstOrDefault().UserName;

            return fav;
        }

        public FinalApprovalViewModel GetFinalApprovalById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateFinalApproval(FinalApprovalViewModel finalApprovalViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
