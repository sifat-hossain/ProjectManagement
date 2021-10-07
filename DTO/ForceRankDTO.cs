using ProjectManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.DTO
{
    public class ForceRankDTO
    {
        
        public int ForceRankId { get; set; }
        public string ForceRankName { get; set; }
        public int? RankTypeId { get; set; }
        public string RankTypeName { get; set; }
    }
}
