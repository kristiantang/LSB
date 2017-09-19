using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LSB.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Menu()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult UserStatements()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult FooterMenu()
        {
            return PartialView();
        }
    }
}