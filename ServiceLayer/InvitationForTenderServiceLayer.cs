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
    public class InvitationForTenderServiceLayer : IInvitationForTender
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public InvitationForTenderServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreateInvitationForTender(InvitationForTenderViewModel invitationForTenderViewModel, IFormFile InvitationForTenderAttachment)
        {
            string result;
            if (invitationForTenderViewModel == null && InvitationForTenderAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(InvitationForTenderAttachment.FileName);
                fileExtension = Path.GetExtension(InvitationForTenderAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/InvitationForTenderAttachment/", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await InvitationForTenderAttachment.CopyToAsync(stream);
                stream.Close();
                invitationForTenderViewModel.InvitationForTenderAttachment = fileName;
            }
            catch
            {
                throw;
            }
            InvitationForTender invitationForTender = mapper.Map<InvitationForTender>(invitationForTenderViewModel);
            await dbContext.InvitationForTenders.AddAsync(invitationForTender);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Created Invitation";
            }
            catch
            {
                throw new DbUpdateException();
            }
            return result;
        }

        public async Task<List<InvitationForTenderViewModel>> GetAllInvitationForTender()
        {
            List<InvitationForTenderViewModel> invitationForTenderViewModel = new();
            try
            {
                List<InvitationForTender> invitationForTender = await dbContext.InvitationForTenders.FromSqlRaw("exec SpGetInvitaionForTendar").ToListAsync();
                foreach(var item in invitationForTender)
                {
                    var _invitaionForTender = dbContext.InvitationForTenders.FromSqlRaw("exec SpGetInvitaionForTendarById {0}", item.InvitationForTenderId).ToList().FirstOrDefault();
                    invitationForTenderViewModel.Add(await InvitationForTenderViewModel(_invitaionForTender));
                }
            }
            catch
            {
                throw;
            }
            return invitationForTenderViewModel;
        }
        public async Task<InvitationForTenderViewModel> InvitationForTenderViewModel(InvitationForTender invitationForTender)
        {
            InvitationForTenderViewModel ift = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            List<VendorInformation> vendorInformation= await dbContext.VendorInformations.FromSqlRaw("exec SpGetVendorInformation").ToListAsync();
            ift.InvitationForTenderId = invitationForTender.InvitationForTenderId;
            ift.InvitationForTenderAttachment = invitationForTender.InvitationForTenderAttachment;
            ift.InvitationForTenderDate = invitationForTender.InvitationForTenderDate;
            ift.ProjectName = project.Where(x => x.ProjectId == invitationForTender.ProjectId).FirstOrDefault().ProjectName;
            ift.VendorName = vendorInformation.Where(x => x.VendorId == invitationForTender.VendorId).FirstOrDefault().VendorName;
            return ift;
        }
        public InvitationForTenderViewModel GetInvitationForTenderById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateInvitationForTender(InvitationForTenderViewModel invitationForTenderViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
