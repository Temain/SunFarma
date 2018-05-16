using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Street
    {
        public int StreetId { get; set; }
        public string StreetCode { get; set; }
        public string StreetName { get; set; }
        public string StreetFullName { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}