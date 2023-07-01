using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Prueba.Controllers; 

namespace Prueba.Permisos
{
    public class ValidarSessionAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var httpContext = filterContext.HttpContext;
          
            if (httpContext.Session.GetString("usuario") == null)
            {
                filterContext.Result = new RedirectResult("~/Access/Login");
            }
            base.OnActionExecuting(filterContext);
        }


    }
}