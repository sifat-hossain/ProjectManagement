using AutoMapper;
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
    public class RankTypeServiceLayer : IRankType
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public RankTypeServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreateRankType(RankTypeViewModel rankTypeViewModel)
        {
            string result = null;
            try
            {
                if (rankTypeViewModel != null)
                {
                    RankType rankType = mapper.Map<RankType>(rankTypeViewModel);
                    await dbContext.RankTypes.AddAsync(rankType);
                    await dbContext.SaveChangesAsync();
                    result = "Successfully Inserted";
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<RankTypeViewModel>> GetAllRankType()
        {
            List<RankType> rankType = await dbContext.RankTypes.FromSqlRaw("exec SpGetAllRankType").ToListAsync();
            List<RankTypeViewModel> rankTypeViewModel = mapper.Map<List<RankTypeViewModel>>(rankType);
            return rankTypeViewModel;
        }

        public RankTypeViewModel GetRankTypeById(int? id)
        {
            var _rankType = dbContext.RankTypes.FromSqlRaw("exec SpGetRankTypeById {0}", id).ToList().FirstOrDefault();
            RankType rankType = _rankType;
            RankTypeViewModel rankTypeViewModel = mapper.Map<RankTypeViewModel>(rankType);
            return rankTypeViewModel;
        }

        public async Task<string> UpdateRankType(RankTypeViewModel rankTypeViewModel)
        {
            string result;
            try
            {
                RankType rankType = mapper.Map<RankType>(rankTypeViewModel);
                dbContext.RankTypes.Update(rankType);
                await dbContext.SaveChangesAsync();
                result = "Seccessfully Updated";
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }
    }
}
