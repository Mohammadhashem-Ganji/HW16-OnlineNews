using HW16.EntitiesConfigoration;
using HW16.Views;
using Microsoft.EntityFrameworkCore;

namespace HW16.Models
{
    public class OnlineNews : DbContext
    {
        // Data Source=.;Initial Catalog=master;Integrated Security=True
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OnlineNews;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Tbl_ArticleConfigoration());
            modelBuilder.ApplyConfiguration(new Tbl_CategoryConfigoration());
            modelBuilder.ApplyConfiguration(new Tbl_UserConfigoration());
            modelBuilder.ApplyConfiguration(new Tbl_WorkflowConfigoration());
            modelBuilder.Entity<Tbl_User>().Property(e => e.Role).HasConversion(v => v.ToString(),v => (Tbl_Role)Enum.Parse(typeof(Tbl_Role), v));
            modelBuilder.Entity<Tbl_Workeflow>().Property(e => e.Status).HasConversion(v => v.ToString(), v => (Tbl_Status)Enum.Parse(typeof(Tbl_Status), v));
        }
        public DbSet<Tbl_Workeflow> Tbl_Workeflows { get; set; }
        public DbSet<Tbl_User> Tbl_Users { get; set; }
        public DbSet<Tbl_Category> Tbl_Categories { get; set; }
        public DbSet<Tbl_Article> Tbl_Articles { get; set; }
    }
}
