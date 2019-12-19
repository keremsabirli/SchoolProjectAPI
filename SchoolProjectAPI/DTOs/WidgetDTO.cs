using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    class LiteWidgetDTO : SharedEntitiesDTO
    {
        public string Title { get; set; }
    }
    class WidgetDTO : LiteWidgetDTO
    {

    }
    class DetailedWidgetDTO : WidgetDTO
    {

    }
}
