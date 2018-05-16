using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderStatus { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public DateTime? SentDate { get; set; }
        public DateTime ReceiveDate { get; set; }

        public int Positions { get; set; }
        public decimal TotalSum { get; set; }

        public int WaybillId { get; set; }
        public Waybill Waybill { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}