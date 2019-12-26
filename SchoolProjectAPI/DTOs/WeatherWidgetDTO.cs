using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    public class LiteWeatherWidgetDTO : SharedEntitiesDTO
    {
        public string City { get; set; }
        public long UserId { get; set; }
    }
    public class WeatherWidgetDTO : LiteWeatherWidgetDTO
    {
        public UserDTO User { get; set; }
    }
    public class DetailedWeatherWidgetDTO : WeatherWidgetDTO
    {

    }
}
