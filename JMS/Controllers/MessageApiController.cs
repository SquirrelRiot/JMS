using JMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JMS.Services;

namespace JMS.Controllers
{
 
    [RoutePrefix("api/message")]
    public class MessageApiController : ApiController
    {
        
        [Route("ConfirmEmail"), HttpPost]
        public async System.Threading.Tasks.Task<HttpResponseMessage> SendConfirmMail(JuryModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
           
           await  MessagingService.SendConfirmationEmail(model);

            return Request.CreateResponse();

        }

    }
}
