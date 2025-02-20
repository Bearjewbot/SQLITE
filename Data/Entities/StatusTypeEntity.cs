using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class StatusTypeEntity
{
    [Key] public int StatusTypeId { get; set; }
    
    public ICollection<ProjectEntity> Projects { get; set; } = [];
    
    
    [Required] 
    [MaxLength(50)] public string StatusType { get; set; } = null!;
}