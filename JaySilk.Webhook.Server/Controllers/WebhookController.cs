using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JaySilk.Webhook.Common.Mvc.Extensions;
using JaySilk.Webhook.Common.Mvc;

namespace JaySilk.Webhook.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class WebhookController : ControllerBase
    {

        [HttpPost]
        //[ServiceFilter(typeof(GitHubSignatureResourceFilter))]
        [VerifyGitHubSignature("1234")]
        public void Post()
        {

        }

        [HttpPost("middleware")]
        public void MiddlewarePost()
        {

        }

    }


}
