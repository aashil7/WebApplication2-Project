using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.repository;

namespace WebApplication2.Controllers.API
{
    public class SampleController : ApiController
    {
       
        [HttpPost]
        [Route("Sample/project")]
        public IHttpActionResult project(SampleController vm)
        {
            return Ok();
        }
    }
}
