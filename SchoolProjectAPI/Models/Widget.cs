using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class Widget : SharedEntities
    {
        public string Title { get; set; }
    }
}
