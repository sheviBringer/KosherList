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
    [RoutePrefix("api/users")]

    public class UsersController: ApiController
    {
        [HttpGet]
        [Route("getAllUsers")]
        public IHttpActionResult getAllUsers()
        {
            return Ok(UsersBL.GetAllUsers());

        }

        [HttpPost]
        [Route("AddUser")]
        public IHttpActionResult AddUser(UsersDto user)
        {
            return Ok(UsersBL.AddUser(user));

        }
    }
}
//    api/users/getAllUsers
