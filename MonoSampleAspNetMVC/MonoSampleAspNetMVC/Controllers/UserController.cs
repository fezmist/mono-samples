using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MonoSampleAspNetMVC.Data;
using MonoSampleAspNetMVC.Model;

namespace MonoSampleAspNetMVC.Controllers
{
    public class UserController : ApiController
    {
		IUserRepository userRepository = new UserRepository();
        // GET api/users
		[System.Web.Http.Route("api/users")]
		[System.Web.Http.HttpGet()]
        public List<User> GetAll()
        {
            //return new string[] { "value1", "value2" };
			return userRepository.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
