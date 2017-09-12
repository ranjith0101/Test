using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomateDeployWeb.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        
        private int Add(int a, int b)
        {
            return a + b;
        }
        
        private int Sub(int a, int b)
        {
            return a - b;
        }
    }
}