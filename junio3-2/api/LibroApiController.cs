using junio3_2.ef;
using junio3_2.Repo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace junio3_2.api
{
    // Restfull

    public class LibroApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Libro> Get()
        {
            return LibroRepo.GetAll();
        }


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}