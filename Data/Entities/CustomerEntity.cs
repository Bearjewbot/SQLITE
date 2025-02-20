using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerEntity
{
    [Key] 
    public int CustomerNumber { get; set; }

    [Required] 
    [MaxLength(50)] 
    public string CustomerName { get; set; } = null!;
    
    [MaxLength(50)]
    public string? CustomerReference { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; } = [];
}