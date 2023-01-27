using CustomActionFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomActionFilter.Controllers
{
    [LogFilter]
    [CustAuthFilter]
    public class HomeController : Controller
    {
        [CustExceptionFilter]
        [CustomActionFilters]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [OutputCache(Duration = 10)]
        public ActionResult OutPutTest()
        {
            ViewBag.Date = DateTime.Now.ToString("T");
            return View();
        }
    }
}