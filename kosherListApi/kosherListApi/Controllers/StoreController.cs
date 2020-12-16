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

    [RoutePrefix("api/store")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class StoreController : ApiController
    {
        [HttpGet]
        [Route("getAllStores")]
        public IHttpActionResult getAllStores()
        {
           return Ok(StoreBL.GetAllStores());
           
        }
    }
//    api/store/getAllStores


}
