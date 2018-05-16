using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string CityFullName { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}