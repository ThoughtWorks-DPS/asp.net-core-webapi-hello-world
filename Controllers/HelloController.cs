using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        // GET api/hello
        [HttpGet]
        public IDictionary<string,string> Get()
        {
            using (_logger.BeginScope("a scope"))
            {
            _logger.LogInformation("we're going to say hello");
            }
            return new Dictionary<string,string> {{ "message", "Hello, World!" }};
        }

    }
}
