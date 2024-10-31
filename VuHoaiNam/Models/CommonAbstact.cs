using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VuHoaiNam.Models
{
    public abstract class CommonAbstact
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}