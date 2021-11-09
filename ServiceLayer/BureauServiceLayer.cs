using Microsoft.EntityFrameworkCore;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.Data;
using AutoMapper;

namespace ProjectManagement.ServiceLayer
{
    public class BureauServiceLayer : IBureau
    {
        public readonly dbContext dbContext;
        public readonly IMapper mapper;
        public BureauServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreateBureau(BureauViewModel bureauViewModel)
        {
            string result;
            Bureau bureau = mapper.Map<Bureau>(bureauViewModel);

            await dbContext.Bureaus.AddAsync(bureau);
            try
            {
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Created The New Bureau";
            }
            catch (DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<BureauViewModel>> GetAllBureau()
        {

            List<Bureau> bureau = await dbContext.Bureaus.FromSqlRaw("exec SpGetBureau").ToListAsync();
            List<BureauViewModel> bureauViewModel = mapper.Map<List<BureauViewModel>>(bureau);
            return bureauViewModel;
        }

        public BureauViewModel GetBureauById(int? id)
        {

            if (id == null)
            {
                throw new KeyNotFoundException();
            }
            else
            {
                Bureau bureau = dbContext.Bureaus.FromSqlRaw("exec SpGetBureau {0}", id).FirstOrDefault();
                BureauViewModel bureauViewModel = mapper.Map<BureauViewModel>(bureau);
                return bureauViewModel;
            }
           
        }


        public async Task<string> UpdateBureau(BureauViewModel bureauViewModel)
        {
            string result;
            Bureau bureau = mapper.Map<Bureau>(bureauViewModel);
            dbContext.Bureaus.Update(bureau);

            try
            {
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Updated The Bureau";
            }
            catch (DbUpdateException e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
