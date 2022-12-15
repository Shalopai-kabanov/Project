using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Apartment
    {
       [Key]
        public int Id{ get; set; }

        [Required]
        [DisplayName("Room number")]
        public string Room_number { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        [DisplayName("Amount of room")]
        public int Amount_of_room { get; set; }

        [Required]
        [DisplayName("Floor number")]
        [Range(1, int.MaxValue)]
        public int Floor_number { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }



        [ForeignKey("Type_of_apartment_id")]
        public virtual Type_of_apartment Type_of_apartment { get; set; }
        [DisplayName("Type of apartment")]
        public int Type_of_apartment_id { get; set; }


        [ForeignKey("Hotel_id")]
        public Hotel Hotel { get; set; }
        [DisplayName("Hotel")]
        public int Hotel_id { get; set; }

    }
}
