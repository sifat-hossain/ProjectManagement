using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            ShipmentItems = new HashSet<ShipmentItem>();
        }

        public int ShipmentId { get; set; }
        public string ShipmentName { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? ShipmentReceivedDate { get; set; }
        public int? UserId { get; set; }
        public string ShipmentFromCountry { get; set; }
        public string ShipmentAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
