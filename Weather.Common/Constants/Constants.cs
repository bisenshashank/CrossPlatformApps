using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Common.Constants
{
    static class Constants
    {
        public const string WeatherApiUrl = "http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt={1}";
        public const string CityName = "noida";
        public const int NoOfDays = 7;
    }
}
