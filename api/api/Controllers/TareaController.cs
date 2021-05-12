using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service.Interfaces;

namespace api.Controllers
{
    [Route("api/Tarea")]
    public class TareaController : Controller
    {
        private readonly ITareaService _tareaService;

        public TareaController(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }

        // GET /values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _tareaService.GetAll()
            );
        }

        // GET /values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _tareaService.Get(id)
            );
        }

        // POST /values
        [HttpPost]
        public IActionResult Post([FromBody] Tarea model)
        {
            return Ok(
                _tareaService.Add(model)
            );
        }

        // PUT /values/5
        [HttpPut]
        public IActionResult Put([FromBody] Tarea model)
        {
            return Ok(
                _tareaService.Update(model)
            );
        }

        // DELETE /values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _tareaService.Delete(id)
            );
        }
    }
}