#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Model;

namespace W21_Assignment.Pages_Cart
{
    public class AddModel : PageModel
    {
        private readonly DBContext _context;

        public AddModel(DBContext context)
        {
            _context = context;
        }
        public W21_Assignment.Model.Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(uint? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductId == id);
            var customer = await _context.Customers.Where(c => c.CustomerId == 1).FirstOrDefaultAsync();

            _context.Cart.Add(new Cart { Product = product, Customer = customer, Quantity = 1 });
            await _context.SaveChangesAsync();



            if (product == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.


    }
}