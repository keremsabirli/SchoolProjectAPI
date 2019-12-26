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
        public DbSet<TextWidget> TextWidgets { get; set; }
        public DbSet<WeatherWidget> WeatherWidgets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonWidget>(b =>
            {
                //b.HasOne(x => x.User).WithMany(x => x.PersonWidgets).HasForeignKey(x => x.UserId);
                b.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            });
            modelBuilder.Entity<UserWidget>(b =>
            {
                //b.HasOne(x => x.User).WithMany(x => x.UserWidgets).HasForeignKey(x => x.UserId);
                b.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
                b.HasOne(x => x.Widget).WithMany(x => x.UserWidgets).HasForeignKey(x => x.WidgetId);
            });
            modelBuilder.Entity<TextWidget>(b =>
            {
                //b.HasOne(x => x.User).WithMany(x => x.TextWidgets).HasForeignKey(x => x.UserId);
                b.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            });
            modelBuilder.Entity<WeatherWidget>(b =>
            {
                //b.HasOne(x => x.User).WithMany(x => x.TextWidgets).HasForeignKey(x => x.UserId);
                b.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId);
            });
        }
    }
}
