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
    public class POServiceLayer : IPO
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public POServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreatePO(PoViewModel poViewModel, IFormFile poAttachment)
        {
            string result;
            if (poViewModel==null&&poAttachment.Length<=0)
            {
                throw new NullReferenceException();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(poAttachment.FileName);
                fileExtension = Path.GetExtension(poAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/POAttachment", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await poAttachment.CopyToAsync(stream);
                stream.Close();
                poViewModel.Poattachment = fileName;

            }
            catch
            {
                throw;
            }
            Po po = mapper.Map<Po>(poViewModel);
            await dbContext.Pos.AddAsync(po);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created PO";
            }
            catch
            {
                throw;
            }
            return result;

        }

        public async Task<List<PoViewModel>> GetAllPO()
        {
            List<PoViewModel> poViewModel = new();
            try
            {
                List<Po> po = await dbContext.Pos.FromSqlRaw("exec SpGetAllPO").ToListAsync();
                foreach(var item in po)
                {
                    var _po = dbContext.Pos.FromSqlRaw("exec SpGetPOById {0}", item.Poid).ToList().FirstOrDefault();
                    poViewModel.Add(await PoViewModel(_po));
                }
            }
            catch
            {
                throw;
            }
            return poViewModel;
        }
        public async Task<PoViewModel> PoViewModel(Po po)
        {
            PoViewModel pvm = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();

            pvm.Poid = po.Poid;
            pvm.Podate = po.Podate;
            pvm.Poattachment = po.Poattachment;
            pvm.ProjectId = po.ProjectId;
            pvm.ProjectName = project.Where(x => x.ProjectId == po.ProjectId).FirstOrDefault().ProjectName;

            return pvm;
        }
        public PoViewModel GetPOById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePO(PoViewModel poViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PoViewModel>> GetPOByProjectId(int? ProjectId)
        {
            List<PoViewModel> list = await GetAllPO();
            list = list.Where(id => id.ProjectId == ProjectId).ToList();
            return list;
        }
    }
}
