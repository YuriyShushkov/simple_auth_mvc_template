using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simple_web_template.Models;

namespace simple_web_template.Controllers
{
    public abstract class BaseController : Controller
    {
        protected AppDbContext _context = new AppDbContext();

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }


}