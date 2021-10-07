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
using ProjectManagement.DTO;

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
            List<Project> project =await dbContext.Projects.FromSqlRaw("exec SpGetProject").ToListAsync();

            List<ProjectViewModel> projectViewModel = mapper.Map<List<ProjectViewModel>>(project);
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
