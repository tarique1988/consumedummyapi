using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebHelperLibrary
{
    public class WebHelper
    {
        public static HttpClient httpClient = new HttpClient();


        public async Task<string> GetData(string url)
        {
            try
            {
                HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
                responseMessage.EnsureSuccessStatusCode();

                return await responseMessage.Content.ReadAsStringAsync();
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
