using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserContactInfoEntity
{
    [Key] public int UserId { get; set; }

    public UserEntity User { get; set; } = null!;
    
    
    [Required] 
    [MaxLength(150)] public string Email { get; set; } = null!;
    
    [MaxLength(17)] public string? PhoneNumber { get; set; }
}