using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class PersonWidget : SharedEntities
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
