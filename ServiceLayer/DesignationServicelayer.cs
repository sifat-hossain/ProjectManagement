using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class DesignationServicelayer : IDesignation
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public DesignationServicelayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
              

        public async Task<string> CreateDesignation(DesignationViewModel designationViewModel)
        {
            string result=null;
            try
            {
                if (designationViewModel != null)
                {
                    Designation designation = mapper.Map<Designation>(designationViewModel);
                    await dbContext.Designations.AddAsync(designation);
                    await dbContext.SaveChangesAsync();
                    result = "Seccessfully Created The New Designation";
                }
            }
            catch(Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        public async Task<List<DesignationViewModel>> GetAllDesignation()
        {           
            List<Designation> designation =await dbContext.Designations.FromSqlRaw("exec SpGetDesignation").ToListAsync();
            List<DesignationViewModel> designationViewModel = mapper.Map<List<DesignationViewModel>>(designation);

            return designationViewModel;
        }

        public DesignationViewModel GetDesignationById(int? id)
        {
           var item= dbContext.Designations.FromSqlRaw("exec SpGetDivisionById {0}",id).ToList().FirstOrDefault();

            Designation designation =item;
            DesignationViewModel designationViewModel = mapper.Map<DesignationViewModel>(designation);
            return designationViewModel;
        }

        public async Task<string> UpdateDesignation(DesignationViewModel designationViewModel)
        {
            string result;
            try
            {
                Designation designation = mapper.Map<Designation>(designationViewModel);
                dbContext.Designations.Update(designation);
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Updated";
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
