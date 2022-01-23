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
    public class PSIServiceLayer : IPSI
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;

        public PSIServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreatePSI(PsiViewModel psiViewModel)
        {
            string result;
            if (psiViewModel == null && psiViewModel.PsiAttachmentFile.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(psiViewModel.PsiAttachmentFile.FileName);
                fileExtension = Path.GetExtension(psiViewModel.PsiAttachmentFile.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var directory = Path.Combine(web.WebRootPath, "File/PSIAttachment/");
                var path = Path.Combine(web.WebRootPath, "File/PSIAttachment/", fileName);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var stream = new FileStream(path, FileMode.Create);
                await psiViewModel.PsiAttachmentFile.CopyToAsync(stream);
                stream.Close();
                psiViewModel.PsiAttachment = fileName;
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Psi psi = mapper.Map<Psi>(psiViewModel);
            await dbContext.Psis.AddAsync(psi);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created PSI";
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<PsiViewModel>> GetAllPSI()
        {
            List<PsiViewModel> psiViewModel = new();
            try
            {
                List<Psi> psi = await dbContext.Psis.FromSqlRaw("exec SpGetPSI").ToListAsync();
                foreach(var item in psi)
                {
                    var _psi = dbContext.Psis.FromSqlRaw("exec SpGetPSIById {0}", item.PsiId).ToList().FirstOrDefault();
                    psiViewModel.Add(await PsiViewModel(_psi));
                }
            }
            catch
            {
                throw;
            }
            return psiViewModel;
        }
        public async Task<PsiViewModel> PsiViewModel(Psi psi)
        {
            PsiViewModel pvm = new();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            pvm.PsiId = psi.PsiId;
            pvm.ProjectId = psi.ProjectId;
            pvm.ProjectName = project.Where(x => x.ProjectId == psi.ProjectId).FirstOrDefault().ProjectName;
            pvm.PsiAttachment = psi.PsiAttachment;
            pvm.PsiDuration = 1 + Convert.ToInt32(psi.PsiEndDate.Value.Date.Day) - Convert.ToInt32(psi.PsiStartDate.Value.Date.Day);
            pvm.PsiEndDate = psi.PsiEndDate;
            pvm.PsiLocation = psi.PsiLocation;
            pvm.PsiStartDate = psi.PsiStartDate;
            return pvm;
        }

        public PsiViewModel GetPSIById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePSI(PsiViewModel psiViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PsiViewModel>> GetPsiByProjectId(int? ProjectId)
        {
            List<PsiViewModel> list = await GetAllPSI();
            list = list.Where(id => id.ProjectId == ProjectId).ToList();
            return list;

        }
    }
}
