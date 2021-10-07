using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.DTO;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class ForceRankServiceLayer : IForceRank
    {
        public readonly dbContext dbContext;
        public readonly AutoMapper.IMapper mapper;
        public ForceRankServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public async Task<string> CreateForceRank(ForceRankViewModel forceRankViewModel)
        {
            string result;
            try
            {
                ForceRank forceRank = mapper.Map<ForceRank>(forceRankViewModel);
                await dbContext.ForceRanks.AddAsync(forceRank);
                await dbContext.SaveChangesAsync();
                result = "Successfully Created";
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public async Task<List<ForceRankViewModel>> GetAllForceRank()
        {
            List<ForceRankDTO> forceRankDTO = await dbContext.ForceRanks.Include(x => x.RankType).Select(x => new ForceRankDTO { ForceRankId = x.ForceRankId, ForceRankName = x.ForceRankName, RankTypeId = x.RankTypeId, RankTypeName = x.RankType.RankTypeName }).ToListAsync();
            List<ForceRankViewModel> forceRankViewModel = mapper.Map<List<ForceRankViewModel>>(forceRankDTO);
            return forceRankViewModel;
        }

        public ForceRankViewModel GetForceRankById(int? id)
        {
            var item = dbContext.ForceRanks.FromSqlRaw("exec SpGetForceRankById {0}", id).ToList().FirstOrDefault();

            ForceRank forceRank = item;
            ForceRankViewModel forceRankViewModel = mapper.Map<ForceRankViewModel>(forceRank);
            return forceRankViewModel;
        }

        public Task<string> UpdateForceRank(ForceRankViewModel forceRankViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
