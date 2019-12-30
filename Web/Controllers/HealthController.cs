using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/Hanlth")]
    public class HealthController : Controller
    {
        [HttpGet]
        public ActionResult get() => Ok("ok！！");
    }
}