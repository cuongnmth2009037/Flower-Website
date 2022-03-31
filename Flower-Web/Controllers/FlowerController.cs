using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flower_Web.Controllers
{
    public class FlowerController : Controller
    {
        // GET: Flower
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Shopping_cart()
        {
            return View();
        }
        public ActionResult loginUser()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }      
    }
}