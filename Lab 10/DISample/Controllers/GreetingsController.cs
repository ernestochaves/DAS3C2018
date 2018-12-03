using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DISample.Controllers
{
    public class GreetingsController : ApiController
    {
        public IGreetingsService GreetingsService { get; set; }

        // GET api/values
        public string Get()
        {
            return GreetingsService.GetGreeting();
        }
    }
}
