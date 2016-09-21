using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simple_web_template.Models;

namespace simple_web_template.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        public string About()
        {
            return "This is about page. User: "+ User.Identity.GetUserRole();
        }
        public string Contact()
        {
            int id = User.Identity.GetUserId<int>();
             return "Ваш id: " + id.ToString();
        }
    }
}