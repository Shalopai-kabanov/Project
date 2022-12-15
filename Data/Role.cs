using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name of role")]
        public string Name_of_role { get; set; }
    }
}
