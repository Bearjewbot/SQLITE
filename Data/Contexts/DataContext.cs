using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext: DbContext
{

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<CustomerTypeEntity> CustomerTypes { get; set; }
    
    public DbSet<ProjectEntity> Projects { get; set; }
    public DbSet<ServiceTypeEntity> ServiceTypes { get; set; } 
    public DbSet<StatusTypeEntity> StatusTypes { get; set; }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserContactInfoEntity> UserContactInfo { get; set; }
    
    // Nedan kod är kopierad från ChatGPT
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<CustomerTypeEntity>().HasData(
            new CustomerTypeEntity { Id = 1, CustomerType = "Företag" },
            new CustomerTypeEntity{Id = 2, CustomerType = "Privat Person"}
        );
 
        modelBuilder.Entity<UserContactInfoEntity>().HasData(
            new UserContactInfoEntity { Id = 1, Email = "Doggy@hotmail.com", UserEntityId = 1 },
            new UserContactInfoEntity{Id = 2, Email = "Catty@hotmail.com", UserEntityId = 1}
        );
 
        modelBuilder.Entity<CustomerEntity>().HasData(
            new CustomerEntity { Id = 1, Name = "Bobby AB", CustomerTypeId = 1 },
            new CustomerEntity{Id = 2, Name = "Björn Gustavsson", CustomerTypeId = 2}
        );
 
        modelBuilder.Entity<UserEntity>().HasData(
            new UserEntity { Id = 1, FirstName = "Lars", LastName = "Björnsson"},
            new UserEntity{ Id = 2, FirstName = "Gunnar", LastName = "Strömming"}
        );
 
        modelBuilder.Entity<ServiceTypeEntity>().HasData(
            new ServiceTypeEntity { Id = 1, ServiceType = "Konsultation 1000kr/tim"},
            new ServiceTypeEntity{ Id = 2, ServiceType = "Utveckling 1500kr/tim"}
        );
 
        modelBuilder.Entity<StatusTypeEntity>().HasData(
            new StatusTypeEntity { Id = 1, StatusType = "Planerad" },
            new StatusTypeEntity{Id = 2, StatusType = "Påbörjad"},
            new StatusTypeEntity{Id = 3, StatusType = "Avslutad"}
        );
    }
}
