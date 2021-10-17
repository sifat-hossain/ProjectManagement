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
    public class InitialNoteSheetServiceLayer :IInitialNoteSheet
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public InitialNoteSheetServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreateInitialNoteSheet(InitialNotesheetViewModel initialNotesheetViewModel, IFormFile initialNoteSheetAttachment)
        {
            string result;
            if (initialNotesheetViewModel == null && initialNoteSheetAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(initialNoteSheetAttachment.FileName);
                fileExtension = Path.GetExtension(initialNoteSheetAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/InitialNoteSheetAttachment", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await initialNoteSheetAttachment.CopyToAsync(stream);
                stream.Close();
                initialNotesheetViewModel.InitialNotesheetAttachment = fileName;

            }
            catch

            {
                throw;
            }
            InitialNotesheet initialNotesheet = mapper.Map<InitialNotesheet>(initialNotesheetViewModel);
            await dbContext.InitialNotesheets.AddAsync(initialNotesheet);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Created The Note Sheet";
            }
            catch
            {
                throw;
            }
            return result;
        }

        public async Task<List<InitialNotesheetViewModel>> GetAllInitialNoteSheet()
        {
            List<InitialNotesheetViewModel> initialNotesheetViewModel = new();
            try
            {
                List<InitialNotesheet> initialNotesheet = await dbContext.InitialNotesheets.FromSqlRaw("exec SpGetInitialNoteSheet").ToListAsync();
                foreach (var item in initialNotesheet)
                {
                    var _initailaNoteSheet = dbContext.InitialNotesheets.FromSqlRaw("exec SpGetInitialNoteSheetById {0}", item.InitialNotesheetId).ToList().FirstOrDefault();
                    initialNotesheetViewModel.Add(await InitialNotesheetViewModel(_initailaNoteSheet));
                }
            }
            catch
            {
                throw;
            }
            return initialNotesheetViewModel;
        }
        public async Task<InitialNotesheetViewModel> InitialNotesheetViewModel(InitialNotesheet initialNotesheet)
        {
            InitialNotesheetViewModel insvm = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            List<VendorInformation> vendorInformation = await dbContext.VendorInformations.FromSqlRaw("exec SpGetVendorInformation").ToListAsync();

            insvm.InitialNotesheetId = initialNotesheet.InitialNotesheetId;
            insvm.InitialNoteSheetOpeningDate = initialNotesheet.InitialNoteSheetOpeningDate;
            insvm.InitialNotesheetSubject = initialNotesheet.InitialNotesheetSubject;
            insvm.ProjectName = project.Where(x => x.ProjectId == initialNotesheet.ProjectId).FirstOrDefault().ProjectName;
            insvm.VendorName = vendorInformation.Where(x => x.VendorId == initialNotesheet.VendorId).FirstOrDefault().VendorName;
            return insvm;
        }
        public InitialNotesheetViewModel GetInitialNoteSheetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateInitialNoteSheet(InitialNotesheetViewModel initialNotesheetViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
