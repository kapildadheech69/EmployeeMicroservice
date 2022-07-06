using System;
using System.Net.Http;

namespace OfferMicroservice.Models
{
    public class OfferHelper
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:443/");
            return client;
        }
    }
}
