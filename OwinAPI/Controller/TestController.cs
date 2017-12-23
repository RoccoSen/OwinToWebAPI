using System.Collections.Generic;
using System.Web.Http;

namespace OwinAPI.Controller
{
    public class TestController : ApiController
    {
        public IEnumerable<string> GetTest()
        {
            return new string[] { "One", "Two", "Three" };
        }
    }
}
