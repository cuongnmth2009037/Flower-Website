using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CartItem { get; set; }
        public double TotalPrice { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhone { get; set; }
    }
}