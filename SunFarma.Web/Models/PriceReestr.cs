using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class PriceReestr
    {
        public int PriceReestrId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Maker { get; set; }

        public int PriceId { get; set; }
        public Price Price { get; set; }

        public decimal? Tax { get; set; }
        public decimal Cost { get; set; }
        public int Left { get; set; }

        public decimal DifferencePercent { get; set; }
        public decimal LeaderPrice { get; set; }
        public int Reting { get; set; }
        public int TotalPos { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}