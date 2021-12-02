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
    public class PGVerificationServiceLayer : IPGVerification
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;

        public PGVerificationServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreatePgVerification(PgVerificationViewModel pgVerificationViewModel)
        {
            string result;
           if(pgVerificationViewModel==null)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(pgVerificationViewModel.PGVerificationAttachmentFile.FileName);
                fileExtension = Path.GetExtension(pgVerificationViewModel.PGVerificationAttachmentFile.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds + "" + fileExtension;
                var directory = Path.Combine(web.WebRootPath, "File/PgVerificationAttachment/");
                var path = Path.Combine(web.WebRootPath, "File/PgVerificationAttachment/", fileName);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                var stream = new FileStream(path, FileMode.Create);
                await pgVerificationViewModel.PGVerificationAttachmentFile.CopyToAsync(stream);
                stream.Close();
               pgVerificationViewModel.PgVerificationAttachment = fileName;
            }
            catch
            {
                throw;
            }
            PgVerification pgVerification = mapper.Map<PgVerification>(pgVerificationViewModel);
            await dbContext.PgVerifications.AddAsync(pgVerification);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "PG Verification Created Successfully";
            }
            catch(DbUpdateException ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public async Task<List<PgVerificationViewModel>> GetAllPgVerification()
        {
            List<PgVerificationViewModel> pgVerificationViewModel = new();
            try
            {
                List<PgVerification> pgVerification = await dbContext.PgVerifications.FromSqlRaw("exec SpgetPGVerification").ToListAsync();
                foreach(var item in pgVerification)
                {
                    var _pgVerification = dbContext.PgVerifications.FromSqlRaw("exec SpgetPGVerificationById {0}", item.PgVerificationId).ToList().FirstOrDefault();
                    pgVerificationViewModel.Add(await PgVerificationViewModel(_pgVerification));
                }
            }
            catch
            {
                throw new Exception();
            }
            return pgVerificationViewModel;   
        }

        public async Task<PgVerificationViewModel> PgVerificationViewModel(PgVerification pgVerification)
        {
            PgVerificationViewModel pg = new();
            List<Noa> noa = await dbContext.Noas.FromSqlRaw("exec SpGetNoa").ToListAsync();
            List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
            pg.NoaCode = noa.Where(x => x.NoaId == pgVerification.NoaId).FirstOrDefault().NoaCode;
            pg.ProjectName = project.Where(x => x.ProjectId == pgVerification.Noa.ProjectId).FirstOrDefault().ProjectName;
            pg.PgVerificationStatus = pgVerification.PgVerificationStatus;
            pg.PgVerificationId = pgVerification.PgVerificationId;
            pg.PgVerificationAttachment = pgVerification.PgVerificationAttachment;
            pg.PgPrice = pgVerification.PgPrice;
            pg.PgOpeningDate = pgVerification.PgOpeningDate;
            pg.PgExpireDate = pgVerification.PgExpireDate;

            return pg;
        }
        public PgVerificationViewModel GetPgVerificationById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdatePgVerification(PgVerificationViewModel pgVerificationViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
