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


namespace ProjectManagement.ServiceLayer
{
    public class ProjectServiceLayer : IProject
    {
        private readonly dbContext dbContext;
        private readonly IMapper mapper; 
        public ProjectServiceLayer(dbContext _dbContext, IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreateProject(ProjectViewModel projectViewModel)
        {
            string result;
           if(projectViewModel==null)
            {
                throw new Exception();
            }
            Project project = mapper.Map<Project>(projectViewModel);
            await dbContext.Projects.AddAsync(project);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Created The New Project";
            }
            catch(DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<ProjectViewModel>> GetAllProject()
        {
            List<ProjectViewModel> projectViewModel = new();
            try
            {
                ProjectViewModel pv = new();
                List<Project> project = await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();
                List<Bureau> bureau = await dbContext.Bureaus.FromSqlRaw("exec SpGetBureau").ToListAsync();
                
                foreach (var item in project)
                {
                    pv.ProjectId = item.ProjectId;
                    pv.ProjectName = item.ProjectName;
                    pv.ProjectInitialBudget = item.ProjectInitialBudget;
                    pv.ProjectFinalBudget = item.ProjectFinalBudget;
                    pv.ProjectStartDate = item.ProjectStartDate;
                    pv.ProjectEndDate = item.ProjectEndDate;
                    pv.ProjectDescription = item.ProjectDescription;
                    pv.ProjectAttachment = item.ProjectAttachment;
                    pv.BureauName = bureau.Where(x => x.BureauId == item.BureauId).FirstOrDefault().BureauName;
                    projectViewModel.Add(pv);

                }
            }
            catch
            {
                throw;
            }
            return projectViewModel;
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
