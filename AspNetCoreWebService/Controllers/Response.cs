using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Controllers
{
    public class Response
    {
        public Response(string o)
        {
            Output = o;
        }

        public string Output
        {
            get;
            private set;
        }
    }
}
