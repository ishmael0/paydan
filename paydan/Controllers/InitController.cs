using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paydan.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paydan.Controllers
{
    public class InitController : Controller
    {
        public IActionResult Index()
        {
            this.JR(StatusCodes.Status101SwitchingProtocols);
            return View();
        }
    }
}
