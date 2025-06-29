using Microsoft.AspNetCore.Mvc;

namespace BudgetTracker.API.Controllers
{
    public class WalletsController : BaseApiController
    {
        // GET: api/<WalletsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WalletsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WalletsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WalletsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WalletsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
