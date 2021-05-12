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
    [Route("api/Ciudadano")]
    public class CiudadanoController : Controller
    {
        private readonly ICiudadanoService _ciudadanoService;

        public CiudadanoController(ICiudadanoService ciudadanoService)
        {
            _ciudadanoService = ciudadanoService;
        }

        // GET /values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _ciudadanoService.GetAll()
            );
        }

        // GET /values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _ciudadanoService.Get(id)
            );
        }

        // POST /values
        [HttpPost]
        public IActionResult Post([FromBody] Ciudadano model)
        {
            return Ok(
                _ciudadanoService.Add(model)
            );
        }

        // PUT /values/5
        [HttpPut]
        public IActionResult Put([FromBody] Ciudadano model)
        {
            return Ok(
                _ciudadanoService.Update(model)
            );
        }

        // DELETE /values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _ciudadanoService.Delete(id)
            );
        }
    }
}