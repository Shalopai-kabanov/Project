using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class Employee
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }


        [ForeignKey("Role_id")]
        public  Role Role { get; set; } 
        [DisplayName("Role")]
        public int Role_id { get; set; }

        [ForeignKey("Hotel_id")]
        public Hotel Hotel { get; set; }
        [DisplayName("Hotel")]
        public int Hotel_id { get; set; }
    }
}
