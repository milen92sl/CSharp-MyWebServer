using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebServer.Server.Http
{
    public class HttpResponse
    {
        public HttpStatusCode StatusCode {get; set;}

        public HttpHeaderCollection Headers = new HttpHeaderCollection();

        public string Content { get; private set; }
    }
}
