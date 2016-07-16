using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewExample.Models
{
    public class MenuItems : Item
    {
        public List<Item> ChildItems { get; set; }
    }
}