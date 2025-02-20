using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{

    public DbSet<ProjectEntity> Projects { get; set; }
    
    public DbSet<CustomerEntity> Customers { get; set; }
    
    public DbSet<CustomerTypeEntity> CustomerTypes { get; set; }

    public DbSet<ServiceTypeEntity> ServiceTypes { get; set; }

    public DbSet<StatusTypeEntity> StatusTypes { get; set; }

    public DbSet<UserContactInfoEntity> UserContactInfo { get; set; }

    public DbSet<UserEntity> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


    }
}
