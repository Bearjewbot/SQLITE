using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectEntity
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)] 
    public string Description { get; set; } = null!;

    [MaxLength(500)] 
    public string? Notes { get; set; }
    
    [Required] 
    public int Price { get; set; }

    [Required] 
    [MaxLength(50)] 
    public string StartDate { get; set; } = null!;
    
    [Required] 
    [MaxLength(50)] 
    public string? EndDate { get; set; }
    
    public CustomerEntity Customer { get; set; } = null!;
    public UserEntity User { get; set; } = null!;
    public StatusTypeEntity Status { get; set; } = null!;
    public ServiceTypeEntity Service { get; set; } = null!;
}