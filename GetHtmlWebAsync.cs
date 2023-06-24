using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TestPerformanceAsyncAwait
{
    public interface IMyHttpClient
    {
        Task<string> GetHtmlWebAsync(string url);
    }

    public class MyHttpClient : IMyHttpClient
    {
        public async Task<string> GetHtmlWebAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string responseBody = "";
                try
                {
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyApp", "1.0"));
                    HttpResponseMessage response = await client.GetAsync(url);
                    responseBody = await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Send request to {url} has error: {ex.Message}");
                }
                // response.EnsureSuccessStatusCode();

                return responseBody;
            }
        }
    }
}