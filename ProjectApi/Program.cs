using Business.Interfaces;
using Business.Services;
using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source=project.db"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerTypeRepository, CustomerTypeRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
builder.Services.AddScoped<IStatusTypeRepository, StatusTypeRepository>();
builder.Services.AddScoped<IUserContactInfoRepository, UserContactInfoRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IServiceTypeService, ServiceTypeService>();
builder.Services.AddScoped<IStatusTypeService, StatusTypeService>();
builder.Services.AddScoped<IUserService, UserService>();


var app = builder.Build();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    // !: Apply migrations and create the database at runtime if it doesn't exist
    // Source:
    // https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#apply-migrations-at-runtime
    using var scope = app.Services.CreateScope();

    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>();

    // Ensure the database is created and apply migrations only if needed.
    await context.Database.MigrateAsync();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseAuthorization();
app.Run();


