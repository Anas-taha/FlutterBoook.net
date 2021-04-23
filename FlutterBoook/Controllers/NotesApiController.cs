
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
    public class NotesApiController : ControllerBase
    {
        FlutterbookContext _context;
        public NotesApiController(FlutterbookContext flutterbook)
        {
            _context = flutterbook;
        }

        // GET: api/<NotesApiController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Note.ToList());
        }

        // GET api/<NotesApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NotesApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NotesApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NotesApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
