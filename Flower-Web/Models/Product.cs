using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Key]
        [ForeignKey("Category")]       
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }      
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }     
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }
    }
}