using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserContactInfoEntity
{
    public int Id { get; set; }
    
    [Required] 
    [MaxLength(150)] 
    public string Email { get; set; } = null!;
    
    [MaxLength(17)] 
    public string? PhoneNumber { get; set; }
    
    public int UserEntityId { get; set; }
    
    public UserEntity User { get; set; } = null!;
}