using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UdpReceiver.Model;

namespace UdpReceiver
{
    public class SenderToApi
    {
        

        public static async Task<TOut> Post<TIn, TOut>(string uri, TIn item)
        {
            Car car = new Car();

            using HttpClient client = new HttpClient();
            string CarObject = JsonConvert.SerializeObject(car);
            StringContent requestContent = new StringContent(CarObject, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(uri, requestContent);
            string responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TOut data = JsonConvert.DeserializeObject<TOut>(responseContent);
                return data;
            }
            throw new KeyNotFoundException($"Status code={response.StatusCode} Message={responseContent}");
        }
    }
}
