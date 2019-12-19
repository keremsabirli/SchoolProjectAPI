using Microsoft.EntityFrameworkCore;

namespace SchoolProjectAPI.Models
{
    public class SchoolProjectContext : DbContext
    {
        public SchoolProjectContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserWidget> UserWidgets { get; set; }
    }
}
