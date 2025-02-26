namespace Business.Models;

public class Project
{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public string? Notes { get; set; }
    
    public int Price { get; set; }
    public string StartDate { get; set; } = null!;
    public string? EndDate { get; set; }
    
    public Customer Customer { get; set; } = null!;
    public User User { get; set; } = null!;
    public StatusType StatusType { get; set; } = null!;
    public ServiceType Service { get; set; } = null!;
}