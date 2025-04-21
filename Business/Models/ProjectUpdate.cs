namespace Business.Models;

public class ProjectUpdate
{
    public int Id { get; set; }
    
    public string Description { get; set; } = null!;
    
    public string? Notes { get; set; }
    
    public string StartDate { get; set; } = null!;
    
    public string? EndDate { get; set; }
    
    public int Price { get; set; }
    
    public int CustomerId { get; set; }
    
    public int StatusId { get; set; }
    
    public int ServiceId { get; set; }
    
    public int UserId { get; set; }
}