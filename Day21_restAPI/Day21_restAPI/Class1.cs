using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using RestSharp.Deserializers;
using RestSharp;

namespace Day21_restAPI
{
    class Class1
    {
        public static void test()
        {
            var client = new RestClient("https://covidapi.info/api/v1/country/IND/latest");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
