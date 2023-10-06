using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.ModelBinding;
using System.Web.Mvc;

namespace LayoutMvc.Models
{
    public class EmployeeBinder : IModelBinder
    {
        //public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        //{
        //    throw new NotImplementedException();
        //}
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            String Id = controllerContext.HttpContext.Request.Form["Id"];
            String firstName = controllerContext.HttpContext.Request.Form["FirstName"];
            String lastName = controllerContext.HttpContext.Request.Form["LastName"];
            String Birth = controllerContext.HttpContext.Request.Form["Birth"];
            String Street = controllerContext.HttpContext.Request.Form["Street"];
            String Province = controllerContext.HttpContext.Request.Form["Province"];
            String ZipCode = controllerContext.HttpContext.Request.Form["ZipCode"];

            return new Employee() { Id = Convert.ToInt32(Id), FullName = firstName + " " + lastName, Birth = Birth, Address = Street + ", " + Province + ", " + ZipCode };
        }
    }
}