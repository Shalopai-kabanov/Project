using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Partner_type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Partner type name")]
        public string Partner_type_name { get; set; }
    }
}
