using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThaWeb.Services;

namespace ThaWeb.Controllers
{
    public class HomeController : Controller
    {
        [Import]
        public IServiceTester ServiceTester { get; set; }

        [Import]
        public IWrapperServiceTestForFun WrapperServiceTestForFun { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(WrapperServiceTestForFun.GetNumbersRanomly());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(ServiceTester.GetSomeDataRandomly());
        }
    }
}