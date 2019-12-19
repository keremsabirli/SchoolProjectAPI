using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
