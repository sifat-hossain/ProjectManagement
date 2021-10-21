using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ProjectManagement.Data;
using ProjectManagement.Interface;
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
         
            if (tenderOpeningViewModel == null && tenderOpeningAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(tenderOpeningViewModel.FileName);
                fileExtension = Path.GetExtension(tenderOpeningViewModel.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/InitialNoteSheetAttachment", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await tenderOpeningViewModel.CopyToAsync(stream);
                stream.Close();
               

            }
            catch

            {
                throw;
            }
            return "";
        }

        public Task<List<TenderOpeningViewModel>> GetAllTenderOpening()
        {
            throw new NotImplementedException();
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
