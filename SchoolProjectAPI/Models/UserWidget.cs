using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProjectAPI.Models
{
    public class UserWidget : SharedEntities
    {

        public long UserId { get; set; }
        public virtual User User { get; set; }
        public long WidgetId { get; set; }
        public virtual Widget Widget { get; set; }
    }
}
