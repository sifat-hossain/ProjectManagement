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
    public class TenderOpeningServiceLayer : ITenderOpening
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public TenderOpeningServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreateTenderOpening(TenderOpeningViewModel tenderOpeningViewModel, IFormFile tenderOpeningAttachment)
        {
            string result;
            if (tenderOpeningViewModel == null && tenderOpeningAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(tenderOpeningAttachment.FileName);
                fileExtension = Path.GetExtension(tenderOpeningAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/TenderOpeningAttachment", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await tenderOpeningAttachment.CopyToAsync(stream);
                stream.Close();
                tenderOpeningViewModel.TenderOpeningAttachment = fileName;

            }
            catch

            {
                throw;
            }
            TenderOpening tenderOpening = mapper.Map<TenderOpening>(tenderOpeningViewModel);
            await dbContext.TenderOpenings.AddAsync(tenderOpening);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Inserted";
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<TenderOpeningViewModel>> GetAllTenderOpening()
        {
            List<TenderOpeningViewModel> tenderOpeningViewModel = new();
            try
            {
                List<TenderOpening> tenderOpening = await dbContext.TenderOpenings.FromSqlRaw("exec SpGetAllTenderOpening").ToListAsync();
                foreach(var item in tenderOpening)
                {
                    var _tendarOpening =  dbContext.TenderOpenings.FromSqlRaw("exec SpGetAllTenderOpeningById {0}", item.TenderOpeningId).ToList().FirstOrDefault();
                    tenderOpeningViewModel.Add(await TenderOpeningViewModel(_tendarOpening));
                }
            }
            catch
            {
                throw;
            }
            return tenderOpeningViewModel;
        }
        public async Task<TenderOpeningViewModel> TenderOpeningViewModel(TenderOpening tenderOpening)
        {
            TenderOpeningViewModel tovm = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            tovm.TenderOpeningId = tenderOpening.TenderOpeningId;
            tovm.TenderOpeningDate = tenderOpening.TenderOpeningDate;
            tovm.TenderClosingDate = tenderOpening.TenderClosingDate;
            tovm.TenderOpeningAttachment = tenderOpening.TenderOpeningAttachment;
            tovm.TenderHonorium = tenderOpening.TenderHonorium;
            tovm.ProjectName = project.Where(x => x.ProjectId == tenderOpening.ProjectId).FirstOrDefault().ProjectName;
            tovm.ProjectId = tenderOpening.ProjectId;
            return tovm;

        }
        public TenderOpeningViewModel GetTenderOpeningById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateTenderOpening(TenderOpeningViewModel tenderOpeningViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
