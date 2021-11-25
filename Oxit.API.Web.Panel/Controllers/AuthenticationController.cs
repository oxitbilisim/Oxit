using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Oxit.Common.Domain;
using Oxit.Common.Models;
using Oxit.Common.ViewModels.Person;
using Oxit.Core;
using Oxit.Infrastructure;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Oxit.API.Web.Panel.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]/")]
    public class AuthenticationControlle : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        public AuthenticationControlle(
            IMapper mapper,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration
            )
        {

            this.mapper = mapper;
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Register(string Email, string Password)
        {

            var res = await userManager.CreateAsync(new IdentityUser(Email), Password);
            var user = await userManager.FindByNameAsync(Email);
            Permissions.getAllPermissions().ForEach(permission =>
            {
                if (!string.IsNullOrEmpty(permission.Permission))
                    userManager.AddClaimAsync(user, new Claim("permission", permission.Permission));
            });
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string Username, string Password)
        {


            var user = await userManager.FindByNameAsync(Username);
            if (user != null && await userManager.CheckPasswordAsync(user, Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var userClaims = await userManager.GetClaimsAsync(user);
                var authClaims = new List<Claim>() {

                new Claim(ClaimTypes.Name, user.Id.ToString())
            };


                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(Settings.JWT.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();

        }

    }


}