using HoBoWebApi.Models;
using HoBoWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HoBoWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class HoBoCController : ApiController
    {
        public readonly HoBoInterface ilhobo;
        public HoBoCController() { }
        public HoBoCController(HoBoInterface ighobo)
        {
            this.ilhobo = ighobo;
        }

        [Route ("api/HoBoC/getAllDetails")]
        [HttpGet]
        public List<HoBoM> getAllDetails()
        {
            var result = ilhobo.getAllDetails();
            return result;
        }

        [Route ("api/HoBoC/insert")]
        [HttpPost]
        public IHttpActionResult insertIntoTable(HoBoM m)
        {
            var insert = ilhobo.insertIntoTable(m);
            return Ok(insert);
        }
        [Route ("api/HoBoC/delete/{id}")]
        [HttpDelete]
        public IHttpActionResult deleteFromTable(int id)
        {
            var delete = ilhobo.deleteFromTable(id);
            return Ok(delete);
        }
    }
}
