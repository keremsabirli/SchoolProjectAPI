using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Models
{
    public class SchoolProjectContext : DbContext
    {
        public SchoolProjectContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserWidget> UserWidgets { get; set; }
    }
}
