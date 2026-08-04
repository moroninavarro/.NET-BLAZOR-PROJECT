using Microsoft.AspNetCore.Identity;
using BookTracker.Data;
using BookTracker.Models;

namespace BookTracker.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app.MapPost("/auth/login", async (
            HttpContext context,
            SignInManager<ApplicationUser> signInManager) =>
        {
            var form = await context.Request.ReadFormAsync();

            var email = form["Email"].ToString();
            var password = form["Password"].ToString();

            var result = await signInManager.PasswordSignInAsync(
                email,
                password,
                false,
                false
            );

            if (result.Succeeded)
            {
                return Results.Redirect("/");
            }

            return Results.Redirect("/login?error=true");
        });
    }
}