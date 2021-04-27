using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Http;

namespace WebDemoAPI.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/values")]
    public class Values2Controller : ApiController
    {
        // GET: api/Values2
        public IEnumerable<string> Get()
        {
            //throw new NotImplementedException("");
            return new string[] { "version2", "version2" };
        }

        // GET: api/Values2/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values2
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values2/5
        public void Delete(int id)
        {
        }
    }
}
