using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolProjectAPI.Models
{
    public class User : SharedEntities
    {
        [StringLength(80, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string MailAddress { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public virtual List<UserWidget> UserWidgets { get; set; }
        public virtual List<PersonWidget> PersonWidgets { get; set; }
        public virtual List<TextWidget> TextWidgets { get; set; }
    }
}
