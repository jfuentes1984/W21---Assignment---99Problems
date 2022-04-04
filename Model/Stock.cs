using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W21_Assignment.Model;

public class Stock
{
    public uint StockId { get; set; }
    public uint Quantity { get; set; } = 0;
    public virtual Product? Product { get; set; }

}