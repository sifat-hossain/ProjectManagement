using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class ShipmentItem
    {
        public int ShipmentItemId { get; set; }
        public int? ShipmentId { get; set; }
        public int? ProductId { get; set; }
        public string ShipmentItemStatus { get; set; }

        public virtual Product Product { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
