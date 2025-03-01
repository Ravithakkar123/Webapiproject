using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.API.Data;

namespace WebApi.API.Controllers
{
    // http://localhost:5000/api/values/5 
    [Route("api/[Controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
          private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]

        public async Task<IActionResult> GetValues()
        {
              var values =await _context.Values.ToListAsync();
              return Ok(values);

        }

        //GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetValue(int id)
        {
            var value =await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpPut("{id}")]
        public void Delete(int id)
        {

        }
    }
}