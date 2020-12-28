using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.services;
using DTO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;



namespace kosherListApi.Controllers
{
    [RoutePrefix("api/Updates")]

    public class UpdatesController : ApiController
    {
        [HttpGet]
        [Route("getAllUpdates")]
        public IHttpActionResult getAllUpdates()
        {
            return Ok(UpdatesBL.GetAllUpdates());
        }
        [HttpPost]
        [Route("AddUpdate")]
        public IHttpActionResult AddUpdate(UpdatesDto Update)
        {
            return Ok(UpdatesBL.AddUpdate(Update));

        }
    }

    //    api/Updates/getAllUpdates

}