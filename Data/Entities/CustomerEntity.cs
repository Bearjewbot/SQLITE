using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerEntity
{
    public int Id { get; set; }
    
    [Required] 
    [MaxLength(50)] 
    public string Name { get; set; } = null!;
    
    [MaxLength(50)]
    public string? ContactPerson { get; set; }
    
    public ICollection<ProjectEntity> Projects { get; set; } = [];
   
    public CustomerTypeEntity CustomerType { get; set; } = null!;
}