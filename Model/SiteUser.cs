using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace W21_Assignment.Model;

public class SiteUser : IdentityUser
{
    [PersonalData]
    [MaxLength(128)]
    public string? Name { get; set; } = "Full Name";
    [PersonalData]
    // boolean for a checkbox 
    public bool IsQualified { get; set; }
    // for radio buttons employee or Customer
    [PersonalData]
    public string? UserType { get; set; }
    [PersonalData]
    [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
    public int StreetNumber { get; set; } = 1;
    [PersonalData]
    public string? StreetName { get; set; }
    [PersonalData]
    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$", ErrorMessage = "Please enter postal code in A1A 1A1 format")]
    public string? PostalCode { get; set; }
    [PersonalData]
    public string? City { get; set; }
    [PersonalData]
    public string? Province { get; set; }
    [PersonalData]
    public string? Phone { get; set; }

    public virtual IList<Cart>? CartItems { get; set; }

}