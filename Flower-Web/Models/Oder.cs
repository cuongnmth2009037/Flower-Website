using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class Oder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int UserId { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
    }
}