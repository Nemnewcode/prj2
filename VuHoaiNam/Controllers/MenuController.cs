using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuHoaiNam.Models;

namespace VuHoaiNam.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbcontext db = new ApplicationDbcontext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuTop() {
           
            return PartialView("_MenuTop");
        }
    }
}