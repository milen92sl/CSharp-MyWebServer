using System;
using System.Collections.Generic;
using System.Text;
using MyWebServer.Server.Http;

namespace MyWebServer.Server.Routing
{
    public interface IRoutingTable
    {
        void Map(string url, HttpResponse response);

        void Map(string url, HttpMethod method, HttpResponse response);

        void MapGet(string url, HttpResponse response);

        void MapPost(string url, HttpResponse response);
    }
}
