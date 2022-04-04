#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W21_Assignment.Model;
using System.Security.Claims;

namespace W21_Assignment.Pages_User;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DBContext _context;
    [BindProperty]
    public User UserInfo { get; set; }

    public IndexModel(ILogger<IndexModel> logger, DBContext context)
    {
        _logger = logger;
        _context = context;
    }

    // public new IList<W21_Assignment.Model.User> User { get; set; }


    public string UserEmail { get; set; }
    public async Task<IActionResult> OnGetAsync()
    {
        UserInfo = await _context.User.FirstOrDefaultAsync();
        if (User.Identity != null)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            if (claimsIdentity.IsAuthenticated)
            {
                var email = claimsIdentity.FindFirst(ClaimTypes.Email);
                if (email != null)
                {
                    UserEmail = email.Value;
                    _logger.Log(LogLevel.Information, email.Value);
                }
                // foreach (var cl in claimsIdentity.Claims)
                // {
                //     _logger.Log(LogLevel.Information, $"{cl.Type}:{cl.Value}");
                // }
            }
        }

        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (UserInfo != null)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Attach(UserInfo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        _logger.Log(LogLevel.Information, UserInfo.Name);
        return RedirectToPage("../Index");
    }

}
