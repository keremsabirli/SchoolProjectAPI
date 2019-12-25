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
        public DbSet<PersonWidget> PersonWidgets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonWidget>(b =>
            {
                b.HasOne(x => x.User).WithMany(x => x.PersonWidgets).HasForeignKey(x => x.UserId);
            });
            modelBuilder.Entity<UserWidget>(b =>
            {
                b.HasOne(x => x.User).WithMany(x => x.UserWidgets).HasForeignKey(x => x.UserId);
                b.HasOne(x => x.Widget).WithMany(x => x.UserWidgets).HasForeignKey(x => x.WidgetId);
            });
            modelBuilder.Entity<TextWidget>(b =>
            {
                b.HasOne(x => x.User).WithMany(x => x.TextWidgets).HasForeignKey(x => x.UserId);
            });
        }
    }
}
