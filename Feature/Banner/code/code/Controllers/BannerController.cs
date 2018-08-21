using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScHelix.Feature.Banner.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner
        public ActionResult BasicBanner()
        {

            return View();
        }
    }
}