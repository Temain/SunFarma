using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionFullName { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}