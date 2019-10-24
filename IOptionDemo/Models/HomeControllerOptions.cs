using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOptionDemo.Models
{
    public class HomeControllerOptions
    {
        public string Title { get; set; }

        public DropdownType DropDown { get; set; }
    }

    public class DropdownType
    {
        public bool City { get; set; }
        public bool State { get; set; }
    }
}
