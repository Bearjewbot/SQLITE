using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class CustomerTypeEntity
{
    [Key] public int CustomerTypeId { get; set; }
    
    public ICollection<CustomerEntity> Customers { get; set; } = [];
    

    [Required] public string CustomerType { get; set; } = null!;
}