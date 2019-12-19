using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProjectDTOs_
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
