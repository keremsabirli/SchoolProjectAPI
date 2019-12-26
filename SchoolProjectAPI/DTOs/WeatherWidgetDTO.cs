using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    public class LiteWeatherWidgetDTO : SharedEntitiesDTO
    {
        public string City { get; set; }
    }
    public class WeatherWidgetDTO : LiteWeatherWidgetDTO
    {

    }
    public class DetailedWeatherWidgetDTO : WeatherWidgetDTO
    {

    }
}
