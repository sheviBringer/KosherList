using BLL.services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace kosherListApi.Controllers
{
    [RoutePrefix("api/worker")]
    public class WorkerController : ApiController
    {
        [HttpGet]
        [Route("getAllWorkers")]
        public IHttpActionResult getAllWorkers()
        {
            return Ok(WorkerBL.GetAllWorkers());

        }
        [HttpPost]
        [Route("AddWorker")]
        public IHttpActionResult AddWorker(WorkerDto worker)
        {
            return Ok(WorkerBL.AddWorker(worker));

        }
    }
}

       

        


    //    api/store/getAllStores



