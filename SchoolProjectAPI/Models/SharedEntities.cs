using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProjectAPI.Models
{
    public class SharedEntities
    {
        public long Id { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
