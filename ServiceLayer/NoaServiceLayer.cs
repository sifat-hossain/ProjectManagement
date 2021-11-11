﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ProjectManagement.ServiceLayer
{
    public class NoaServiceLayer : INoa
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;

        public NoaServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }

        public async Task<string> CreateNoa(NoaViewModel noaViewModel, IFormFile noaAttachment)
        {

            string result;
            if (noaViewModel == null && noaAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(noaAttachment.FileName);
                fileExtension = Path.GetExtension(noaAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/NoaAttachment/", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await noaAttachment.CopyToAsync(stream);
                stream.Close();
                noaViewModel.NoaAttachment = fileName;
            }
            catch
            {
                throw;
            }
            Noa noa = mapper.Map<Noa>(noaViewModel);
            await dbContext.Noas.AddAsync(noa);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "NOA added successfully";
            }
            catch
            {
                throw new DbUpdateException();
            }
            return result;
        }

        public async Task<List<NoaViewModel>> GetAllNoa()
        {
            List<NoaViewModel> noaViewModel = new();
            try
            {
                List<Noa> noa = await dbContext.Noas.FromSqlRaw("exec SpGetNoa").ToListAsync();
                foreach (var item in noa)
                {
                    var _noa = dbContext.Noas.FromSqlRaw("exec SpGetNoaById {0}", item.NoaId).ToList().FirstOrDefault();
                    noaViewModel.Add(await NoaViewModel(_noa));
                }
            }
            catch
            {
                throw;
            }
            return noaViewModel;
        }


        public async Task<NoaViewModel> NoaViewModel(Noa noa)
        {
            NoaViewModel nvm = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            nvm.NoaId = noa.NoaId;
            nvm.NoaCode = noa.NoaCode;
            nvm.FinalContatractPrice = noa.FinalContatractPrice;
            nvm.TenderNo = noa.TenderNo;
            nvm.NoaAttachment = noa.NoaAttachment;
            nvm.Pgdate = noa.Pgdate;
            nvm.ProjectName = project.Where(x => x.ProjectId == noa.ProjectId).FirstOrDefault().ProjectName;
            return nvm;
        }



        public NoaViewModel GetNoaById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateNoa(NoaViewModel noaViewModel)
        {
            throw new NotImplementedException();
        }
    }
}