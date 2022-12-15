using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Paid_services
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name of paid service")]
        public string Name_of_paid_service { get; set; }
    }
}
