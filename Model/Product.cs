using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W21_Assignment.Model;

public class Product
{
    public int ProductId { get; set; }
    [MaxLength(128)]
    public string? Name { get; set; } = "Product Name";
    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "Decimal(7,2)")]
    public decimal Price { get; set; } = 1.00M;
    public string? Description { get; set; }

}