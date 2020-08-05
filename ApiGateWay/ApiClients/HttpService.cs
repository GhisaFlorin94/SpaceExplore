//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Text.Json;
//using Microsoft.AspNetCore.Http;

//namespace ApiGateWay.ApiClients
//{
//    public class HttpService :IHttpService
//    {

//        private readonly HttpClient _httpClient;
//        public HttpService()
//        {
//            _httpClient = new HttpClient();
//            _httpClient.DefaultRequestHeaders.Accept.Clear();
//            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//        }

//        public void InitializeAuthHeader(string authToken)
//        {
//            var authHeader = new AuthenticationHeaderValue(authToken);
//            _httpClient.DefaultRequestHeaders.Authorization = authHeader;
//        }


//        public string GetFeedData<T>(HttpRequest request)
//        {
//            try
//            {
//                _httpClient.SendAsync(request.);

//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//                return null;
//            }
//        }

//        public string Post<T>(string url, string body)
//        {
//            var stringContent = new StringContent(body, Encoding.UTF8, "application/json");
//            var response = _httpClient.PostAsync(url, stringContent).Result;

//            return response.Content.ReadAsAsync<T>().Result;
//        }

//        private string GetApiResult<T>(string uri)
//        {
//            var response = _httpClient.GetAsync(uri).Result;

//            if (!response.IsSuccessStatusCode) return null;

//            var stream = response.Content.ReadAsStreamAsync().Result;
//            return stream;
//        }

//    }

//}
//}
