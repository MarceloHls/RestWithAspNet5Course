using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet("teste/{nome}")]
        public IActionResult teste(string nome)
        {
            return Ok($"Ola {nome}");
        }
    }
}
