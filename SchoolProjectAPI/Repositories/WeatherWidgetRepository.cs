using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class WeatherWidgetRepository : BaseRepository<WeatherWidget>, IWeatherWidgetRepository
    {
        public WeatherWidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
