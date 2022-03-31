using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class Cartitem
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double ProductUnitPrice { get; set; }

        public int Quantity { get; set; }

        public string ShoppingCartItem { get; set; }
    }
}