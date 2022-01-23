using AutoMapper;
using Microsoft.AspNetCore.Hosting;
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
    public class LCServiceLayer : ILC
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;

        public LCServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }

        public async Task<List<LcViewModel>> Details()
        {
            List<LcViewModel> viewModel = new();
            try
            {
                List<Lc> data = await dbContext.Lcs.FromSqlRaw("exec SpGetLC").ToListAsync();

                foreach (var item in data)
                {
                    var _data = dbContext.Lcs.FromSqlRaw("exec SpGetLCById {0}", item.Lcid).ToList().FirstOrDefault();
                    viewModel.Add(await LcViewModel(_data));
                }
            }
            catch
            {
                throw;
            }
            viewModel.Sort((a, b) => b.Lcid.CompareTo(a.Lcid));
            return viewModel;
        }

        public async Task<LcViewModel> LcViewModel(Lc model)
        {
            LcViewModel viewModel = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            viewModel.Lcid = model.Lcid;
            viewModel.LcopeningDate = model.LcopeningDate;
            viewModel.NominatedBank = model.NominatedBank;
            viewModel.PaymentProcess = model.PaymentProcess;
            viewModel.LcAttachment = model.Lcattachment;
            viewModel.ProjectId = model.ProjectId;
            viewModel.ProjectName = project.Where(x => x.ProjectId == model.ProjectId).FirstOrDefault().ProjectName;
            return viewModel;
        }

        public async Task<string> Create(LcViewModel viewModel)
        {

            string result;
            if (viewModel == null && viewModel.LCAttachmentFile.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(viewModel.LCAttachmentFile.FileName);
                fileExtension = Path.GetExtension(viewModel.LCAttachmentFile.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var directory = Path.Combine(web.WebRootPath, "File/LCAttachment/");
                var path = Path.Combine(web.WebRootPath, "File/LCAttachment/", fileName);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var stream = new FileStream(path, FileMode.Create);
                await viewModel.LCAttachmentFile.CopyToAsync(stream);
                stream.Close();
                viewModel.LcAttachment = fileName;
            }
            catch
            {
                throw;
            }
            Lc model = mapper.Map<Lc>(viewModel);
            await dbContext.Lcs.AddAsync(model);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "LC added successfully!";
            }
            catch
            {
                throw new DbUpdateException();
            }
            return result;
        }

        public async Task<List<LcViewModel>> GetLCByProjectId(int? projectId)
        {
            List<LcViewModel> lcList = await Details();
            lcList = lcList.Where(id => id.ProjectId == projectId).ToList();

            return lcList;
        }

    }
}
