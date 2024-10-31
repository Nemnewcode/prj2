using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuHoaiNam.Models.EF
{
    [Table("product")]
    public class Product : CommonAbstact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProductCategoryID { get; set; }
        
        public int Detail { get; set; }
       
        public string Image { get; set; } 

        public decimal Price { get; set; }

        public decimal PriceSale { get; set; }

    }
}