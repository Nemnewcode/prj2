using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuHoaiNam.Models.EF
{
    [Table("Category")]
    public class Category : CommonAbstact
    {
        public Category() {
            this.news = new HashSet<New>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWord { get; set; }

        public int Position { get; set; }    
       
       public ICollection<New> news { get; set; }
        public ICollection<Post> Posts { get; set; }


    }
}