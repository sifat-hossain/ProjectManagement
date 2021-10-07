using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class ForceRank
    {
        public ForceRank()
        {
            UserInformations = new HashSet<UserInformation>();
        }

        public int ForceRankId { get; set; }
        public string ForceRankName { get; set; }
        public int? RankTypeId { get; set; }

        public virtual RankType RankType { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}
