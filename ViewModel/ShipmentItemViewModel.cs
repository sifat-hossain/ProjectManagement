using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ShipmentItemViewModel
    {
        public int ShipmentItemId { get; set; }
        public int? ShipmentId { get; set; }
        public int? ProductId { get; set; }
        public string ShipmentItemStatus { get; set; }

        public virtual Product Product { get; set; }
        public virtual Shipment Shipment { get; set; }
    }
}
