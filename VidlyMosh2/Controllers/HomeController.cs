using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace VidlyMosh2.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //For Html cache, give each user each cache for duration 50s, it is based on Param "genre"!
        //      [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "genre")]  

        // For Html cache, give each user each cache for duration 50s, it is based on all different Param!
        //      [OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")]

        //For Html cache, diable cache for the user
        //        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)]

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}