using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project1.Models;
using Project1.Providers;
namespace Project1.Controllers
{
    public class ValuesController : ApiController
    {
        ResultSet result = new ResultSet();
        // GET api/values
        [HttpGet]
        [Route("api/get")]
        public HttpResponseMessage GetPost(string method, PostModels post)
        {
            try
            {
                //not completed
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                result.code = 0;
                result.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        [HttpPost]
        [Route("api/createPost")]
        public HttpResponseMessage PostCreate([FromBody]PostModels post)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return Request.CreateResponse(HttpStatusCode.BadRequest,new ResultSet() { code=0,message="Bad Request"});
                }
                using (var provider = new PostProvider()) {
                    return Request.CreateResponse(HttpStatusCode.OK, provider.createPost(post));
                }
            }
            catch (Exception ex)
            {
                result.code = 0;
                result.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        [HttpPost]
        [Route("api/deletePost")]
        public HttpResponseMessage delete()
        {
            try
            {
                //not completed
                return Request.CreateResponse(HttpStatusCode.OK,result);
            }
            catch (Exception ex)
            {
                result.code = 0;
                result.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
        [HttpPost]
        [Route("api/updatePost")]
        public HttpResponseMessage update([FromBody]PostModels post)
        {

            try
            {
                //not completed
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                result.code = 0;
                result.message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.InternalServerError, result);
            }
        }
    }
}
