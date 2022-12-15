using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Cost { get; set; }

        [DisplayName("Date of reservation")]
        public DateTime Date_of_reservation { get; set; }

        [DisplayName("End of the reservation")]
        public DateTime Date_of_end_reservation { get; set; } 
    }
}
