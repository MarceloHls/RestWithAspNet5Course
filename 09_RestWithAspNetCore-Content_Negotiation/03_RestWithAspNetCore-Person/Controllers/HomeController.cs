using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api-{version:apiVersion}/home")]

    public class HomeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Route_1:api-1/person , Route_2:api-1/book "); 
        }
    }
}
