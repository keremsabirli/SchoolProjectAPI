using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    public class LiteUserWidgetDTO : SharedEntitiesDTO
    {
        public long UserId { get; set; }
        public long WidgetId { get; set; }
    }
    public class UserWidgetDTO : LiteUserWidgetDTO
    {
        public virtual User User { get; set; }
        public virtual Widget Widget { get; set; }
    }
    public class DetailedUserWidgetDTO : UserWidgetDTO
    {

    }
}
