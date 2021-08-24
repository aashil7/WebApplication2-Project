using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.repository;

namespace WebApplication2.Controllers.API
{
    public class ProjectController : ApiController
    {
       
        [HttpPost]
        [Route("Sample/project")]
        public IHttpActionResult SampleAdd(ProjectController Proj)
        {
            return Ok();
        }



        [HttpGet]
        [Route("sample/GetAppRefDataAshil")]
        public IHttpActionResult ProjectStatus(int parentId)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);
        }



    }

    }

