using Microsoft.AspNetCore.Identity;

namespace BookTracker.Models;
/// <summary>
/// Represents a user account in BookTracker.
/// Extends ASP.NET Core Identity user model with 
/// application-specific user information
/// </summary>
public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}