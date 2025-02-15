using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class ProjectEntity
{
    [Key]
    public int ProjectNumber { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Description { get; set; } = null!;

    [Column(TypeName = "nvarchar(max)")]
    public string? Notes { get; set; }
}
