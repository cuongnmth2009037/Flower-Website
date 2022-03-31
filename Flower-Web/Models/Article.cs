using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Flower_Web.Models
{
    public class Article
    {
        public int Id { get; set; }
        [ForeignKey("Category")]
        public int Articlecategory { get; set; }
        public virtual Category Category { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }      
    }
}