using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateWay.ApiClients
{
    public interface IHttpService
    {
        void InitializeAuthHeader(string authToken);
        string GetFeedData(string url, Dictionary<string, string> headers = null);
        string Post(string url, string body);
    }
}
