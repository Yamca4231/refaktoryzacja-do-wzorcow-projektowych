using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace WeatherApiFacade
{
    public struct Coords
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }

    public class WeatherFacade
    {
        private static string APIkey => "2b62abc2b5fd050a7cb55af76e245235";
        private string baseURL = "https://api.openweathermap.org";
        private static readonly HttpClient client = new HttpClient();
        private Coords coords;

        private async Task<string> SendRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }

        private async Task GetCoordinates(string city)
        {
            string cityUrl = $"{baseURL}/geo/1.0/direct?q={city}&limit=1&appid={APIkey}";
            string responseBody = await SendRequest(cityUrl);

            if (responseBody != null)
            {
                dynamic jsonDe = JsonConvert.DeserializeObject(responseBody);
                coords.lon = jsonDe[0].lon;
                coords.lat = jsonDe[0].lat;
            }
        }

        public async Task<double?> GetTemperatureByCity(string city)
        {
            await GetCoordinates(city);
            if (coords.lat != null && coords.lon != null)
            {
                string weatherUrl = $"{baseURL}/data/2.5/weather?lat={coords.lat}&lon={coords.lon}&appid={APIkey}&units=metric";
                string responseBody = await SendRequest(weatherUrl);

                if (responseBody != null)
                {
                    dynamic weatherData = JsonConvert.DeserializeObject(responseBody);
                    return weatherData.main.temp;
                }
            }
            return null;
        }
    }
}