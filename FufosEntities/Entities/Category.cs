
using System.ComponentModel.DataAnnotations;
using Appointment.SDK.Entities;

namespace FufosEntities.Entities;

public class Category : BaseEntity<short>
{
    [Required]
    [StringLength(60)]
    public string Name {get; set;} = null!;

    public ICollection<Product>? Products {get; set;}
}