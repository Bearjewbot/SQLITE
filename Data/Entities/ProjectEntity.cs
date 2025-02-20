using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class ProjectEntity
{
    [Key]
    public int ProjectNumber { get; set; }

    [Required]
    [MaxLength(100)]
    public string Description { get; set; } = null!;

    [MaxLength(500)]
    public string? Notes { get; set; }

    public int CustomerNumber { get; set; }

    public CustomerEntity Customer { get; set; } = null!;
}
