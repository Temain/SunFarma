using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int PriceReestId { get; set; }
        public PriceReestr PriceReestr { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Count { get; set; }
        public decimal Sum { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}