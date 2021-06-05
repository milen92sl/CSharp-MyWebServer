using System;
using System.Collections.Generic;
using System.Text;
using MyWebServer.Server.Common;

namespace MyWebServer.Server.Http
{
    public abstract class HttpResponse
    {

        public HttpResponse(HttpStatusCode statusCode)
        {
            this.StatusCode = statusCode;
            this.Headers.Add("Server", "My Web Server");
            this.Headers.Add("Date", $"{DateTime.UtcNow:r}");
        }
        public HttpStatusCode StatusCode {get; init;}

        public HttpHeaderCollection Headers = new HttpHeaderCollection();

        public string Content { get; private set; }
    }
}
