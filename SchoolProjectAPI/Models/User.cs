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
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public List<UserWidget> UserWidgets { get; set; }
    }
}
