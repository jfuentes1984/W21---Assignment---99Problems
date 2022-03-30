using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W21_Assignment.Model;

public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "Decimal(7,2)")]
    public decimal Price { get; set; } = 5.00M;
    public uint Stock { get; set; } = 0;

}