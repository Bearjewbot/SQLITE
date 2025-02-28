using Data.Entities;

namespace Business.Models;

public class Project
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public string? Notes { get; set; }
    
    public int Price { get; set; }
    public string StartDate { get; set; } = null!;
    public string? EndDate { get; set; }
    
    public Customer? Customer { get; set; }
    
    public User? User { get; set; } 
    
    public StatusType? Status { get; set; } 
    
    public ServiceType? Service { get; set; } 
}