using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Address
    { 
        public int AddressId { get; set; }

        public string Title { get; set; }

        public int CountryId { get; set; }
        public Country County { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int StreetId { get; set; }
        public Street Street { get; set; }

        public string HouseNumber { get; set; }
        public string BuildingNumber { get; set; }
        public string PostalCode { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}