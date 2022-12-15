using MB.Data;
using MB.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MB.ViewModels
{
    public class ApartmentVM
    {
        public Apartment Apartment { get; set; }
        public IEnumerable<SelectListItem> TDDHotel { get; set; }
        public IEnumerable<SelectListItem> TDDType_of_apartment { get; set; }
    }
}
