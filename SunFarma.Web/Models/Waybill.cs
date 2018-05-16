using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Waybill
    {
        public int WaybillId { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }

        public string Phone { get; set; }

        public DateTime? SentDate { get; set; }
        public DateTime ReceiveDate { get; set; }

        public string DocumentLink { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public List<Order> Orders { get; set; }
    }
}