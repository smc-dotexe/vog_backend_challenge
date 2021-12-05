using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Classes.Entities;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected ActionResult CreateResponse(object result)
        {
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
