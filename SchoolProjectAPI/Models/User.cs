using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class User : SharedEntities
    {
        [StringLength(80, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string MailAddress { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public List<UserWidget> UserWidgets { get; set; }
    }
}
