﻿using System.Collections.Generic;
using System.Net;

namespace Microsoft.Azure.Functions.Worker
{
    public class HttpResponseData
    {
        public HttpResponseData(HttpStatusCode statusCode, string? body = null)
        {
            StatusCode = statusCode;
            Body = body;
            Headers = new Dictionary<string, string>();
        }

        public HttpStatusCode StatusCode { get; set; }

        public string? Body { get; set; }

        public Dictionary<string, string> Headers { get; set; }
    }
}