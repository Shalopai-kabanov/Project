using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Rating { get; set; }

        [Required]
        [DisplayName("Phone number")]
        public int Phone_number { get; set; }

        [Required]
        [DisplayName("Floor amount")]
        public int Number_of_floors { get; set; }

        [Required]
        [DisplayName("Amount of apartments")]
        public int Amount_of_apartments { get; set; }

        [Required]
        [DisplayName("Hotel name")]
        public string Hotel_name { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
