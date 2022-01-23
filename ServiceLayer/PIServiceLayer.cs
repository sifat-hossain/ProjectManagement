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
    public class PIServiceLayer : IPI
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;

        public PIServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }

        public async Task<List<PiViewModel>> GetAllPI()
        {
            List<PiViewModel> viewModel = new();
            try
            {
                List<Pi> data = await dbContext.Pis.FromSqlRaw("exec SpGetPI").ToListAsync();

                foreach (var item in data)
                {
                    var _data = dbContext.Pis.FromSqlRaw("exec SpGetPIById {0}", item.PiId).ToList().FirstOrDefault();
                    viewModel.Add(await PiViewModel(_data));
                }
            }
            catch
            {
                throw;
            }
            viewModel.Sort((a, b) => b.PiId.CompareTo(a.PiId));
            return viewModel;
        }

        public async Task<PiViewModel> PiViewModel(Pi model)
        {
            PiViewModel viewModel = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            viewModel.PiId = model.PiId;
            viewModel.Pidate = model.Pidate;
            viewModel.PiAttachment = model.PiAttachment;
            viewModel.ProjectId = model.ProjectId;
            viewModel.ProjectName = project.Where(x => x.ProjectId == model.ProjectId).FirstOrDefault().ProjectName;
            return viewModel;
        }

        public async Task<string> CreatePI(PiViewModel viewModel)
        {

            string result;
            if (viewModel == null && viewModel.PIAttachmentFile.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(viewModel.PIAttachmentFile.FileName);
                fileExtension = Path.GetExtension(viewModel.PIAttachmentFile.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var directory = Path.Combine(web.WebRootPath, "File/PIAttachment/");
                var path = Path.Combine(web.WebRootPath, "File/PIAttachment/", fileName);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var stream = new FileStream(path, FileMode.Create);
                await viewModel.PIAttachmentFile.CopyToAsync(stream);
                stream.Close();
                viewModel.PiAttachment = fileName;
            }
            catch
            {
                throw;
            }
            Pi model = mapper.Map<Pi>(viewModel);
            await dbContext.Pis.AddAsync(model);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "PI added successfully!" ;
            }
            catch
            {
                throw new DbUpdateException();
            }
            return result;
        }

        public async Task<List<PiViewModel>> GetPIByProjectId(int? ProjectId)
        {
            List<PiViewModel> list = await GetAllPI();
            list = list.Where(id => id.ProjectId == ProjectId).ToList();
            return list;
        }
    }
}
