using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Object_type
    {
        [Key]
        public int  Id{ get; set; }

        [Required]
        [DisplayName("Object type name")]
        public string Object_type_name { get; set; }
    }
}
