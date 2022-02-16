using LeafletExample.Models;
using LeafletExample.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeafletExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController : ControllerBase
    {

      
        // GET: api/<CrudController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CrudController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CrudController>
        [HttpPost]
        public string SaveMarker(Marker marker)
        {
            
            MarkerService markerService = new MarkerService();
            markerService.SaveMarker(marker);
           
            return "Eklendi";
        }
        // PUT api/<CrudController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CrudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
