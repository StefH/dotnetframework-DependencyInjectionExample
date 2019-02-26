using System.Collections.Generic;
using System.Web.Http;

namespace WebApplicationWithDI.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ITest _test;

        public ValuesController(ITest test)
        {
            _test = test;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2", _test.X() };
        }
    }
}
