using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolProjectAPI.Models
{
    public class Widget : SharedEntities
    {
        [StringLength(maximumLength: 80,
            MinimumLength = 1,
            ErrorMessage = "Title must have minimum length of 1 and maximum length of 80")]
        public string Title { get; set; }
        public List<UserWidget> UserWidgets { get; set; }
    }
}
