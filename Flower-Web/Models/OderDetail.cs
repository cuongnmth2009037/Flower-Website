using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class OderDetail
    {
        public int Id { get; set; }
        public int ProductDetailId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}