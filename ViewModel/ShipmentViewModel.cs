using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ShipmentViewModel
    {
        public int ShipmentId { get; set; }
        public string ShipmentName { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? ShipmentReceivedDate { get; set; }
        public int? UserId { get; set; }
        public string ShipmentFromCountry { get; set; }
        public string ShipmentAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
    }
}
