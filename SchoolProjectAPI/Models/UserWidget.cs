using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProjectAPI.Models
{
    public class UserWidget : SharedEntities
    {

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public long WidgetId { get; set; }
        [ForeignKey("WidgetId")]
        public virtual Widget Widget { get; set; }
    }
}
