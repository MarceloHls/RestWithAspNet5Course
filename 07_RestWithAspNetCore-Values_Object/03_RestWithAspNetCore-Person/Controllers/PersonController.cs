﻿using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Business.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_RestWithAspNetCore_Person.Business;
using _03_RestWithAspNetCore_Person.Data.VO;

namespace _03_RestWithAspNetCore_Person.Controllers
{
    [ApiVersion("1")]
    [Route("api-{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            PersonVO person = _personBusiness.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]

        public IActionResult Post([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();

            return Ok(_personBusiness.Create(person));
        }

        [HttpPut]

        public IActionResult Put([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();

            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
