using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Object
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Object name")]
        public string Object_name { get; set; }


        [Required]
        [DisplayName("Amount of objects")]
        public int Amount_of_objects { get; set; }

        [Required]
        [DisplayName("Object material")]
        public string Object_material { get; set; }
    }
}
