using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace phase1.Models
{
    public class ProductCarts
    {
        public List<product> products { get; set; }
        public List<cart> carts { get; set; }
    }
}