using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using RestSharp;

namespace client.Models
{
    class Connected
    {
        
        public bool connected { get; }

        public IPAddress myip { get; }
        
        public static Connected Check()
        {
            var restclient = new RestClient("https://lokun.is/");
            var request = new RestRequest("connected.json");
            request.AddHeader("User-Agent", "lokun-client0.3");
            var response = restclient.Execute<Connected>(request);

            return response.Data;
        }
    }
}
