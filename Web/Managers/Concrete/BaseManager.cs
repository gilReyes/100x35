using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Web.Managers
{
    public class BaseManager
    {
        public HttpClient client;
        public BaseManager()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49606/api/");
            //client.BaseAddress = new Uri("http://100x35api.azurewebsites.net/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}