using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProjectDTOs_
{
    class LiteUserWidgetDTO : SharedEntitiesDTO
    {
        public long UserId { get; set; }
        public long WidgetId { get; set; }
    }
    class UserWidgetDTO : LiteUserWidgetDTO
    {
        public virtual User User { get; set; }
        public virtual Widget Widget { get; set; }
    }
    class DetailedUserWidgetDTO : UserWidgetDTO
    {

    }
}
