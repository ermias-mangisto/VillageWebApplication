using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VillageWebApplication.Controllers
{
    public class ChiefController : Controller
    {
       
        public ActionResult ShowChief()
        {
            ViewBag.Chief = "wellcome Chief";
            return View();
        }

        

       
       
    }
}
