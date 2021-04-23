
using FlutterBoook.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlutterBook1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventAPIController : ControllerBase
    {
        FlutterbookContext _context;
        public EventAPIController(FlutterbookContext flutterContxt)
        {
            _context = flutterContxt;

        }

        // GET: api/<EventAPIController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Appointment.ToList());
        }

        // GET api/<EventAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EventAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
