using System;
using System.Collections.Generic;

namespace EasyWeather.Weather
{
    public class WeatherResponseData
    {
        public IList<JsonWeather> weather { get; set; }
        public IList<JsonMain> main { get; set; }
    }
}
