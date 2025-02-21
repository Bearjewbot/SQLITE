using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserEntity
{
    public int Id { get; set; }

    [Required] 
    [MaxLength(50)] 
    public string FirstName { get; set; } = null!;

    [Required] 
    [MaxLength(50)] 
    public string LastName { get; set; } = null!;
    
    public ICollection<ProjectEntity> Projects { get; set; } = [];
    public ICollection<UserContactInfoEntity> ContactInfo { get; set; } = [];
}