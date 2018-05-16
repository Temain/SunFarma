using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunFarma.Web.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierTitle { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public List<Price> Prices { get; set; }
    }
}