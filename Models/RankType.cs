using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class RankType
    {
        public RankType()
        {
            ForceRanks = new HashSet<ForceRank>();
        }

        public int RankTypeId { get; set; }
        public string RankTypeName { get; set; }

        public virtual ICollection<ForceRank> ForceRanks { get; set; }
    }
}
