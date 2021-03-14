using _03_RestWithAspNetCore_Person.Business;
using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_RestWithAspNetCore_Person.Controllers
{

    [ApiVersion("1")]
    [Route("api-{version:apiVersion}/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IBookBusiness _business;

        public BookController(IBookBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_business.FindAll());
        }

        [HttpGet("{id}")]

        public IActionResult GetByID(long id)
        {
            return Ok(_business.FindById(id));
        }

        [HttpPost]

        public IActionResult CreateBook([FromBody] BookVO book)
        {
            return Ok(_business.Create(book));
        }

        [HttpPut]

        public IActionResult Update([FromBody] BookVO book)
        {
            return Ok(_business.Update(book));
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            _business.Delete(id);
            return NoContent();
        }

       
    }
}
