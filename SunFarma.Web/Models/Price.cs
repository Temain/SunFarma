using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public string PriceName { get; set; }
        public string PriceTitle { get; set; }
        public DateTime? LastPerform { get; set; }
        public bool IsActual { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public string PriceLink { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public List<PriceReestr> PriceReestr { get; set; }
    }
}