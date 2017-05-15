using BasicAuthLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApp1.Controllers
{
    public class WebApiController : ApiController
    {
        [HttpGet]
        [BasicAuthFilter]
        public Dictionary<String, String> test()
        {
            Dictionary<String, String> ret = new Dictionary<string, string>();
            ret["Test"] = "Test";
            ret["Test2"] = "Test2";
            return ret;
        }
    }
}
