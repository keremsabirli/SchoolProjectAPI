using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class WeatherWidget : SharedEntities
    {
        public string City { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
