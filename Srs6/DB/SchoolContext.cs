using Microsoft.EntityFrameworkCore;


namespace Srs6.DB
{
    class SchoolContext : DbContext
    {

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public SchoolContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=localhost;Username=postgres;Password=Lotasuk21gaybar;Database=SchoolTest");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().HasKey(t=>t.id);
            modelBuilder.Entity<Role>().HasKey(r=>r.id);
            modelBuilder.Entity<Teacher>().HasOne(t=>t.Role).WithMany(r=>r.teachers).HasForeignKey(r=>r.roleId);
            modelBuilder.Entity<Role>().HasMany(r=>r.teachers).WithOne(t=>t.Role).HasForeignKey(r=>r.roleId);
        }

    }
    class Admin { 
   public int Id { get; set; }   
        public 
    }
}
