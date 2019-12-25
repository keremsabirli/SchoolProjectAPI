using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    public class LiteTextWidgetDTO : SharedEntitiesDTO
    {
        public string Text { get; set; }
        public long UserId { get; set; }
    }
    public class TextWidgetDTO : LiteTextWidgetDTO
    {
        public User User { get; set; }
    }
    public class DetailedTextWidgetDTO : TextWidgetDTO
    {
        
    }
}
