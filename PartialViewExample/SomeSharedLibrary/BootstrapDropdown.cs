using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewExample.SomeSharedLibrary
{
    public class BootstrapDropdown
    {
        public string HeaderText { get; set; }
        public List<DropdownItem> Items { get; set; }
    }
}