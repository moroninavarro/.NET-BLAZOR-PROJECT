using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BookTracker.Models;
using System.Threading.Tasks;

namespace BookTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
[HttpPost("login")]
public async Task<IActionResult> Login([FromBody] LoginModel model)
{
    Console.WriteLine($"Email recibido: '{model.Email}'");
    Console.WriteLine($"Password recibida: '{model.Password}'");

    var user = await _userManager.FindByEmailAsync(model.Email);

    if (user == null)
        return BadRequest("User not found");

    var check = await _userManager.CheckPasswordAsync(user, model.Password);

    if (!check)
        return BadRequest("Password incorrect");

    var result = await _signInManager.PasswordSignInAsync(
        user,
        model.Password,
        true,
        false);

    return Ok(new
    {
        result.Succeeded,
        result.IsLockedOut,
        result.IsNotAllowed,
        result.RequiresTwoFactor
    });
}


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok("Registration successful.");
            }

            return BadRequest(result.Errors);
        }

            
        public  class LoginModel
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

         public  class RegisterModel
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

    }
}