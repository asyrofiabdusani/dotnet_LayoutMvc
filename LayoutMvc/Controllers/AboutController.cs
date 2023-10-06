using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutMvc.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        //[Route("contact")]
        public ActionResult Index()
        {
            return View();
        }
    }
}