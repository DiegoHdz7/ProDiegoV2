using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProDiegoV2.Authorization.Roles;
using ProDiegoV2.Authorization.Users;
using ProDiegoV2.MultiTenancy;
using ProDiegoV2.Models;


namespace ProDiegoV2.EntityFrameworkCore
{
    public class ProDiegoV2DbContext : AbpZeroDbContext<Tenant, Role, User, ProDiegoV2DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<College> Colleges { get; set; }

        public ProDiegoV2DbContext(DbContextOptions<ProDiegoV2DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }


    }
}
