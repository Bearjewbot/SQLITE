using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserContactInfoEntity
{
    [Key] public int UserId { get; set; }

    public UserEntity User { get; set; } = null!;
}