using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApplication1.Controllers
{
    [Route("_status")]
    public class StatusController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "This is the status page";
        }
    }
}
