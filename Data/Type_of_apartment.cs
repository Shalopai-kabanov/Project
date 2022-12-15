using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Type_of_apartment
    {
        [Key]
        public int Id { get; set; }      

        [Required]
        [DisplayName("Name of type of apartment")]
        public string Name { get; set; }
    }
}
