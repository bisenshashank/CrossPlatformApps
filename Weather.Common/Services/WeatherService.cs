using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Weather.Common.Model;
using Newtonsoft.Json.Linq;

namespace Weather.Common.Services
{
    public class WeatherService : IWeatherService
    {
        private WeatherData weatherData;

        private DateTime currentSelectedDate;

        public bool IsNext
        {
            get
            {
                if ((currentSelectedDate.Date - DateTime.Now.Date).TotalDays >= Constants.Constants.NoOfDays - 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool IsPrevious
        {
            get
            {
                if(DateTime.Now.Date < currentSelectedDate.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<DailyTemperature> GetFirst()
        {
            var selectedDate = DateTime.Now;

            return await GetTemperature(selectedDate);
        }
        public async Task<DailyTemperature> GetLast()
        {
            var selectedDate = DateTime.Now.AddDays(Constants.Constants.NoOfDays);
            return await GetTemperature(selectedDate);
        }

        public async Task<DailyTemperature> GetNext()
        {
            var selectedDate = currentSelectedDate.AddDays(1);
            return await GetTemperature(selectedDate);
        }

        public async Task<DailyTemperature> GetPrevious()
        {
            var selectedDate = currentSelectedDate.AddDays(-1);
            return await GetTemperature(selectedDate);
        }

        private async Task<DailyTemperature> GetTemperature(DateTime selectedDate)
        {
            if (weatherData == null || (DateTime.Now - weatherData.RecorededDataime).TotalHours > 3)
            {
                await GetDailyWeatherDataAsync();
            }
            DailyTemperature Temperature = null;
            currentSelectedDate = selectedDate;
            Temperature = weatherData.WeeklyTempraure.FirstOrDefault(x => x.Date.Date.Equals(selectedDate.Date));
            return Temperature;
        }


		public async Task GetDailyWeatherDataAsync()
		{
            var url = string.Format(Constants.Constants.WeatherApiUrl, Constants.Constants.CityName, Constants.Constants.NoOfDays);
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (WebResponse response = await request.GetResponseAsync())
			{
				using (Stream stream = response.GetResponseStream())
				{
					StreamReader reader = new StreamReader(stream, Encoding.UTF8);
					string content = reader.ReadToEnd();

					WeatherJsonData weatherJsonData = JsonConvert.DeserializeObject<WeatherJsonData>(content);
					weatherData = new WeatherData();
					weatherData.RecorededDataime = DateTime.Now;
					currentSelectedDate = DateTime.Now;
					weatherData.WeeklyTempraure = new List<DailyTemperature>();
					foreach (var item in weatherJsonData.list)
					{
						var dateTemperature = new DailyTemperature();
						dateTemperature.City = weatherJsonData.city.name;
						dateTemperature.Country = weatherJsonData.city.country;
						dateTemperature.Date = new System.DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(item.dt);
						dateTemperature.ShortDate = dateTemperature.Date.ToString("dd MMM yyyy");
						dateTemperature.Temperature = item.temp.day + " °C";
						weatherData.WeeklyTempraure.Add(dateTemperature);
					}
				}

			}
		}
    }
}
