using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VuHoaiNam.Models;

namespace VuHoaiNam.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = _dbContext.categories;
            return View(items);
        }
        public ActionResult Add() { 
            return View();

        }
    }
}