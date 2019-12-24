using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.DTOs
{
    public class LitePersonWidgetDTO : SharedEntitiesDTO
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public long UserId { get; set; }
    }
    public class PersonWidgetDTO : LitePersonWidgetDTO
    {
        public UserDTO User { get; set; }
    }
    public class DetailedPersonWidgetDTO : PersonWidgetDTO
    {

    }
}
