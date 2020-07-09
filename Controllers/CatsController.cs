using System;
using System.Collections.Generic;
using catapi.FAKEDB;
using catapi.Models;
using catapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace catapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatsController : ControllerBase
    {
        private readonly CatService _service;

        public CatsController(CatService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cat>> GetAll()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("available")]
        public ActionResult<IEnumerable<Cat>> GetAvail()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")] // api/cats/:id
        public ActionResult<Cat> GetById(string id)// req.params.id
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPost]
        public ActionResult<Cat> Create([FromBody] Cat newCat)// req.body
        {
            try
            {
                return Ok(_service.Create(newCat));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Cat> Edit([FromBody] Cat editCat, string id)// req.params.id
        {
            try
            {
                return Ok(_service.Edit(editCat, id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{catId}")]
        public ActionResult<Cat> Delete(string catId)// req.params.id
        {
            try
            {
                return Ok(_service.Delete(catId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}