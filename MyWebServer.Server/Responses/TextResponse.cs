using System;
using System.Collections.Generic;
using System.Text;
using MyWebServer.Server.Common;
using MyWebServer.Server.Http;

namespace MyWebServer.Server.Responses

{
    public class TextResponse : HttpResponse
    {
        public TextResponse(string text) :
            base(HttpStatusCode.Ok)
        {
            var contentLength = Encoding.UTF8.GetByteCount(text).ToString();
            Guard.AgainstNull(text);
            this.Headers.Add("Content-Type", "text/plain; charset=UTF-8");
            this.Headers.Add("Content-Length", contentLength);
        }
    }
}
