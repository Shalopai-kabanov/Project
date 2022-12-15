﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MB.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
