using SampleWebAPI.Repositary;
using SampleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebAPI.Controllers
{
    public class SampleController : ApiController
    {
        public readonly EmpDetailsInterface EmpI;

        private SampleController() { }

        public SampleController(EmpDetailsInterface empi)
        {
            this.EmpI = empi;
        }

        [Route("Api/Sample/GetAllEmpDetails")]
        [HttpGet]
        public List<EmpModel> GetAllEmpDetails()
        {                        
           var result = EmpI.GetAllEmpDetails();
            return result;
        }

        [Route("Api/Sample/UpdateEmpInfo")]
        [HttpPut]
        public IHttpActionResult UpdateEmp(EmpModel empm)
        {
            if (!ModelState.IsValid)
                return BadRequest(" Not a valid Model ");

            var ret = EmpI.UpdateEmpDetails(empm);
            if (ret == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [Route("Api/Sample/DeleteStudentDetails")]
        [HttpDelete]
        public IHttpActionResult DeleteStudent(string username)
        {
            return null;
        }


        [Route("Api/Sample.InsertStudentDetails")]
        [HttpPut]

        public IHttpActionResult InsertBulkStudent(EmpModel empm) { 
            if (ModelState.IsValid){
            
            }
            return Ok();

        }
    }
}
