using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;

namespace SchoolProjectAPI.DTOs
{
    public class LiteUserDTO : SharedEntitiesDTO
    {
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public DateTimeOffset BirthDate { get; set; }
    }
    public class UserDTO : LiteUserDTO
    {

    }
    public class DetailedUserDTO : UserDTO
    {
        public List<UserWidget> UserWidgets { get; set; }
    }
}
