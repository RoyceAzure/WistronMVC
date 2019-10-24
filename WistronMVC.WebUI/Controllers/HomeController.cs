using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WistronMVC.DataAccess.SQL;
using WistronMVC.Core.Models;

namespace WistronMVC.WebUI.Controllers
{
    public class HomeController : Controller
    {

        SQLRepostory<User> context;

        public HomeController(SQLRepostory<User> context)
        {
            this.context = context;
        }
        public ActionResult Index()
        {
            List<User> Users = context.Collection().ToList();
            return View(Users);
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