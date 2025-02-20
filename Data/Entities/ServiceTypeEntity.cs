using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ServiceTypeEntity
{
    [Key]
    public int ServiceId { get; set; }
    
    public ICollection<ProjectEntity> Projects { get; set; } = [];

    
    [Required] public string ServiceType { get; set; } = null!;
}