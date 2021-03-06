using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ProjectManagement.ServiceLayer
{
    public class ProjectServiceLayer : IProject
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment web;
        string fileName;
        string fileExtension;
        public ProjectServiceLayer(dbContext _dbContext, IMapper _mapper, IWebHostEnvironment _web)
        {
            dbContext = _dbContext;
            mapper = _mapper;
            web = _web;
        }
        public async Task<string> CreateProject(ProjectViewModel projectViewModel, IFormFile ProjectAttachment)
        {
            string result;
            if (projectViewModel == null && ProjectAttachment.Length < 0)
            {
                throw new Exception();
            }
            try
            {
                fileName = Path.GetFileNameWithoutExtension(ProjectAttachment.FileName);
                fileExtension = Path.GetExtension(ProjectAttachment.FileName);
                fileName = fileName + "_" + DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day + "" + DateTime.Now.TimeOfDay.Hours + "" + DateTime.Now.TimeOfDay.Minutes + "" + DateTime.Now.TimeOfDay.Seconds+ "" + fileExtension;
                var path = Path.Combine(web.WebRootPath, "File/ProjectAttachment/", fileName);
                var stream = new FileStream(path, FileMode.Create);
                await ProjectAttachment.CopyToAsync(stream);
                stream.Close();
                projectViewModel.ProjectAttachment = fileName;
            }
            catch
            {
                throw;
            }

            Project project = mapper.Map<Project>(projectViewModel);
            await dbContext.Projects.AddAsync(project);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Successfully Created The New Project";
            }
            catch (DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<ProjectViewModel>> GetAllProject()
        {
            List<ProjectViewModel> projectViewModel=new();
           
            try
            {             
                List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
              
                foreach (var item in project)
                {
                  var _project = dbContext.Projects.FromSqlRaw("exec SpGetProjectById {0}", item.ProjectId).ToList().FirstOrDefault();
                  projectViewModel.Add(await ProjectViewModel(_project));

                }
            }
            catch
            {
                throw;
            }
            return projectViewModel;
        }
        public async Task<ProjectViewModel> ProjectViewModel(Project project)
        {
            ProjectViewModel pv = new();

            List<Bureau> bureau = await dbContext.Bureaus.FromSqlRaw("exec SpGetBureau").ToListAsync();

            pv.ProjectId = project.ProjectId;
            pv.ProjectName = project.ProjectName;
            pv.ProjectInitialBudget = project.ProjectInitialBudget;
            pv.ProjectFinalBudget = project.ProjectFinalBudget;
            pv.ProjectStartDate = project.ProjectStartDate;
            pv.ProjectEndDate = project.ProjectEndDate;
            pv.ProjectDescription = project.ProjectDescription;
            pv.ProjectAttachment = project.ProjectAttachment;
           
            pv.BureauName = bureau.Where(x => x.BureauId == project.BureauId).FirstOrDefault().BureauName;

            return pv;
        }
        public ProjectViewModel GetProjectById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateProject(ProjectViewModel projectViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
