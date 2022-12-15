using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Resident
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        [DisplayName("Phone number")]
        public int Phone_number { get; set; }

        [Required]
        [Range(1000, 9999)]
        public int Seria { get; set; }

        [Required]
        [Range(1000, 999999)]
        public int Number { get; set; }
    }
}
