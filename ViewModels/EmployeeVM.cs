using MB.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MB.ViewModels
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; }

        public IEnumerable<SelectListItem> TDDHotel { get; set; }
        public IEnumerable<SelectListItem> TDDRole { get; set; }
    }
}
