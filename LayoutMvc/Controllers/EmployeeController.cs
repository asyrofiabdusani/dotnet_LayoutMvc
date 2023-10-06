using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayoutMvc.Models;

namespace LayoutMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(EmployeeBinder))] Employee employee)
        {
            return Content(employee.FullName);
        }
    }
}