using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sarthi.Models;

namespace Sarthi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SarthiContext Sa=new SarthiContext();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Register()
        {




            return View();
        }

        public ActionResult Login()
        {




            return View();
        }
    }
}