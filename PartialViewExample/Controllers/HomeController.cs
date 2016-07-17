using PartialViewExample.SomeSharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Boolean isAdmin = false)
        {
            if (isAdmin)
                ViewBag.Menu = new DropdownManager().GetAdmin();
            else
                ViewBag.Menu = new DropdownManager().GetStandard();
            return View();
        }
    }
}