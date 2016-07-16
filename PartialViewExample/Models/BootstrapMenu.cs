using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewExample.Models
{
    public class BootstrapMenu
    {
        public string HeaderText { get; set; }
        public List<MenuItems> Items { get; set; }
    }
}