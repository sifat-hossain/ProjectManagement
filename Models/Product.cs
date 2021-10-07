using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Product
    {
        public Product()
        {
            DefectWithingWarranties = new HashSet<DefectWithingWarranty>();
            FinalAcceptances = new HashSet<FinalAcceptance>();
            PgdwithProducts = new HashSet<PgdwithProduct>();
            ProvisionalAcceptances = new HashSet<ProvisionalAcceptance>();
            ShipmentItems = new HashSet<ShipmentItem>();
            Warranties = new HashSet<Warranty>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductOrigin { get; set; }
        public string ProductTechSpec { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? ProductWarranty { get; set; }

        public virtual ICollection<DefectWithingWarranty> DefectWithingWarranties { get; set; }
        public virtual ICollection<FinalAcceptance> FinalAcceptances { get; set; }
        public virtual ICollection<PgdwithProduct> PgdwithProducts { get; set; }
        public virtual ICollection<ProvisionalAcceptance> ProvisionalAcceptances { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
    }
}
