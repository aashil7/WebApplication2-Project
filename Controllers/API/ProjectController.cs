using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.repository;

namespace WebApplication2.Controllers.API
{
    public class ProjectController : ApiController
    {

        [HttpPost]
        [Route("ProjectApi/SampleAdd")]
        public IHttpActionResult SampleAdd(Project Proj)
        {
            dataTab objRepo = new dataTab();
            var datat = objRepo.GetDataTable(Proj);
            return Ok(datat);
        }







        [HttpGet]
        [Route("ProjectApi/GetAppRefData")]
        public IHttpActionResult ProjectStatus(int parentId)
        {
            common objRepo = new common();
            var appRefStatus = objRepo.GetAppRefData(parentId);
            return Ok(appRefStatus);
        }



        [HttpGet]
        [Route("ProjectApi/GetRecruiters")]
        public IHttpActionResult Recruiters()
        {
            common objRepo = new common();
            var Rec = objRepo.GetRecrut();
            return Ok(Rec);
        }



        [HttpGet]
        [Route("ProjectApi/GetDomains")]
        public IHttpActionResult Domains()
        {
            common objRepo = new common();
            var domain = objRepo.GetDomain();
            return Ok(domain);
        }


        [HttpGet]
        [Route("ProjectApi/GetLocation")]
        public IHttpActionResult Locationgroup()
        {
            common objRepo = new common();
            var locgroup = objRepo.GetLocation();
            return Ok(locgroup);
        }


        [HttpGet]
        [Route("ProjectApi/GetTimeSheetRep")]
        public IHttpActionResult TimesheetRepresent()
        {
            common objRepo = new common();
            var timesheetrep = objRepo.GetTimeSheetRep();
            return Ok(timesheetrep);
        }

        [HttpGet]
        [Route("ProjectApi/GetSalesPerson")]
        public IHttpActionResult SalesPerson()
        {
            common objRepo = new common();
            var saleperson = objRepo.GetSalePerson();
            return Ok(saleperson);
        }


        [HttpGet]
        [Route("ProjectApi/GetPayRoll")]
        public IHttpActionResult PayRoll()
        {
            common objRepo = new common();
            var payroll = objRepo.GetPayRoll();
            return Ok(payroll);
        }


        [HttpGet]
        [Route("ProjectApi/GetProjectsList")]
        public IHttpActionResult DataTab()
        {
            common objRepo = new common();
            var datatable = objRepo.GetProjectsList();
            return Ok(datatable);
        }


        [HttpGet]
        [Route("ProjectApi/GetEmpData")]
        public IHttpActionResult Retrieve(string data)
        {
            dataTab objRepo = new dataTab();
            var retre = objRepo.GetEmpData(data);
            return Ok(retre);
        }



        [HttpPost]
        [Route("ProjectApi/GetEdit")]
        public IHttpActionResult Edittab(int Id)
        {
            dataTab objRep = new dataTab();
            var editt = objRep.Edit(Id);
            return Ok(editt);
        }


        [HttpPost]
        [Route("ProjectApi/GetUpdate")]
        public IHttpActionResult Updatetab(Project obj)
        {
            dataTab objRepos = new dataTab();
            var updt = objRepos.Update(obj);
            return Ok(updt);
        }



 


    }
}

    

