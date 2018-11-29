using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Superheroes2.Controllers
{
    public class SuperheroController : ApiController
    {
        // GET: api/Superhero
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Superhero/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Superhero
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Superhero/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Superhero/5
        public void Delete(int id)
        {
        }
    }
}
