using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paydan.Extentions
{
    public static class CntrollersExtention
    {
        public static JsonResult JR(this Controller controller , int statusCode, string message = null, object data = null)
        {
            JsonResult jr = new JsonResult(new { data, message, status = statusCode, error = "" });
            jr.StatusCode = statusCode;
            return jr;
        }
    }
}
