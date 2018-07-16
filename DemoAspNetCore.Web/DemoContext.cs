using DemoAspNetCore.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAspNetCore.Web
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }
 
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasKey(c => c.Id);
        }
    }
}