using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuHoaiNam.Models.EF
{
    [Table("Contact")]
    public class Contact : CommonAbstact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ten khong duo de trong")]
        [StringLength(150,ErrorMessage ="Khong duoc vuot qua 150")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string Message { get; set; }
        public string IsRead { get; set; }
    }
}