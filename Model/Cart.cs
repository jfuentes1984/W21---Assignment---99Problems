using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W21_Assignment.Model;

public class Cart
{
    public uint CartId { get; set; }
    public virtual Product? Product { get; set; }
    public virtual Customer? Customer { get; set; }
    public uint Quantity { get; set; } = 0;

}