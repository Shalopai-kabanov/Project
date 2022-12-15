using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Data
{
    public class General_partner
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("General Patrner's name")]
        public string General_partner_name { get; set; }
    }
}
