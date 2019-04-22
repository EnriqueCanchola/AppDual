using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AppDual.Controllers
{
    public static class WebApi
    {
        public static HttpClient WebApiClient = new HttpClient();
        static WebApi()
        {
            WebApiClient.BaseAddress = new Uri("http://wsiep.azurewebsites.net/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplicattion/Json"));
        }
    }
}
