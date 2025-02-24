using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ServiceTypeEntity
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string ServiceType { get; set; } = null!;
    
    public ICollection<ProjectEntity> Projects { get; set; } = [];
}