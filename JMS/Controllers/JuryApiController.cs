using JMS.Models;
using JMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JMS.Controllers
{
    [RoutePrefix("api/jury")]
    public class JuryApiController : ApiController
    {
        [Route("check")]
        [HttpPut]
        public HttpResponseMessage CheckInJury(JuryModel model)
        {
            ItemResponse<Boolean> response = new ItemResponse<Boolean>();
            response.Item = JuryList.CheckedIn(model.JuryId);
            return Request.CreateResponse(response);
        }

        [Route("complete")]
        [HttpPut]
        public HttpResponseMessage CompletedJury(JuryModel model)
        {
            ItemResponse<Boolean> response = new ItemResponse<Boolean>();
            response.Item = JuryList.Completed(model.JuryId);
            return Request.CreateResponse(response);
        }
    }
}
