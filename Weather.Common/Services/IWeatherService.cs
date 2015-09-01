using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Common.Model;

namespace Weather.Common.Services
{
    public interface IWeatherService
    {
        bool IsNext { get; }

        bool IsPrevious { get; }

        Task<DailyTemperature> GetFirst();

        Task<DailyTemperature> GetLast();

        Task<DailyTemperature> GetNext();

        Task<DailyTemperature> GetPrevious();

        Task GetDailyWeatherDataAsync();
    }
}
