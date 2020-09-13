using System.Net;
using System.Net.Http;
using System.Web.Http;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.Api;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers.Api
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        // GET: api/Users
        [Route]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET: api/Users/5
        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            switch (id)
            {
                case 1: return Ok();
                case 2: return Ok(new string[] { "value1", "value2" });
                case 3: return BadRequest();
                case 4: return NotFound();
                case 5: return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created));
                case 6:
                default:
                    return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created, new string[] { "value1", "value2" }));
            }
        }

        // POST: api/Users
        [Route()]
        [HttpPost]
        public IHttpActionResult Post(UserDto user)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("V2")]
        [HttpPost]
        [ValidationActionFilter]
        public IHttpActionResult PostV2(UserDto user)
        {
            return Ok();
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
