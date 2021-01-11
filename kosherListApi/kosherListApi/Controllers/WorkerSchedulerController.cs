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
    [RoutePrefix("api/WorkerScheduler")]
    public class WorkerSchedulerController: ApiController
    {
            [HttpGet]
            [Route("getAllWorkerScheduler")]
            public IHttpActionResult getAllWorkerScheduler()
            {
                return Ok(WorkerSchedulerBL.GetAllWorkerScheduler());

            }

            [HttpPost]
            [Route("AddWorkerScheduler")]
            public IHttpActionResult AddWorkerScheduler(WorkerSchedulerDto WorkerScheduler)

            {
                return Ok(WorkerSchedulerBL.AddWorkerScheduler(WorkerScheduler));

            }
        }

    //    api/store/getAllWorkerScheduler


}
