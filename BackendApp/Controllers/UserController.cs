using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using BackendApp.Controllers.Models;
using BackendApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BackendApp.Controllers;

[Route("/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly Context _context;
    private static readonly MD5 Md5 = MD5.Create();

    public UserController(Context context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("/[controller]/[action]")]
    public async Task<ActionResult<User>> Login(LoginModel loginModel)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == loginModel.Email);

        if (user == null)
        {
            return BadRequest("User with specified not found");
        }

        var passwordHash = Convert.ToHexString(Md5.ComputeHash(Encoding.ASCII.GetBytes(loginModel.Password)));

        if (passwordHash != user.Password)
        {
            return BadRequest("Password is incorrect");
        }

        var jwt = new JwtSecurityToken(
            issuer: AuthOptions.Issuer,
            audience: AuthOptions.Audience,
            notBefore: DateTime.UtcNow,
            claims: GetIdentity(user).Claims,
            expires: DateTime.UtcNow.AddMinutes(AuthOptions.Lifetime),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                SecurityAlgorithms.HmacSha256));
        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

        var response = new
        {
            accessToken = encodedJwt,
            email = loginModel.Email,
            userId = user.Id
        };

        return new OkObjectResult(response);
    }

    [HttpPost]
    [Route("/[controller]/[action]")]
    public async Task<ActionResult<User>> Register(RegisterModel registerModel)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == registerModel.Email);

        if (user != null)
        {
            return BadRequest("User with specified email exists");
        }

        var passwordHash = Convert.ToHexString(Md5.ComputeHash(Encoding.ASCII.GetBytes(registerModel.Password)));
        var confirmPasswordHash = Convert.ToHexString(Md5.ComputeHash(Encoding.ASCII.GetBytes(registerModel.ConfirmPassword)));

        if (passwordHash != confirmPasswordHash)
        {
            return BadRequest("Passwords are not equal");
        }

        var newUser = new User
        {
            Email = registerModel.Email,
            Password = passwordHash
        };

        _context.Users.Add(newUser);

        await _context.SaveChangesAsync();

        var jwt = new JwtSecurityToken(
            issuer: AuthOptions.Issuer,
            audience: AuthOptions.Audience,
            notBefore: DateTime.UtcNow,
            claims: GetIdentity(newUser).Claims,
            expires: DateTime.UtcNow.AddMinutes(AuthOptions.Lifetime),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                SecurityAlgorithms.HmacSha256));
        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

        var response = new
        {
            accessToken = encodedJwt,
            email = registerModel.Email,
            userId = newUser.Id
        };

        return new OkObjectResult(response);
    }
    
    private static ClaimsIdentity GetIdentity(User user)
    {
        var claims = new List<Claim>
        {
            new(ClaimsIdentity.DefaultNameClaimType, user.Email),
        };
        var claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
        return claimsIdentity;
    }
}