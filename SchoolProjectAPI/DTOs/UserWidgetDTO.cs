using SchoolProjectAPI.Models;

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
