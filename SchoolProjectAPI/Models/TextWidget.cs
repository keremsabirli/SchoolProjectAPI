using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class TextWidget : SharedEntities
    {
        public string Text { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
    }
}
