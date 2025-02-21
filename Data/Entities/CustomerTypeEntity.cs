using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerTypeEntity
{
    public int Id { get; set; }
    
    [Required] 
    public string CustomerType { get; set; } = null!;
    
    public ICollection<CustomerEntity> Customers { get; set; } = [];
}