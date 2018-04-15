using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunFarma.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectSupplier()
        {
            return View();
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        public ActionResult OrdersHistory()
        {
            return View();
        }

        public ActionResult OrdersInfo()
        {
            return View();
        }

        public ActionResult Reporting()
        {
            return View();
        }
    }
}