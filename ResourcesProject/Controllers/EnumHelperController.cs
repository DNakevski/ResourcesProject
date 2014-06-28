using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResourcesProject.Models;

namespace ResourcesProject.Controllers
{
    public class EnumHelperController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            return View(new MusicBand());
        }
	}
}