using Data.Contexts;
using Data.Entities;

namespace Business.Services;

public class ProjectService(DataContext context)
{
    // Skapa endast services på det du vill lista
    // Hämta alla statusar (get all), projektledare, kunder exempelvis  
    private readonly DataContext _context = context;

}