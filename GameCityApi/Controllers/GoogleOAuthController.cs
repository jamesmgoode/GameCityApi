using GameCityApi.Models;
using GameCityApi.Services.Interfaces;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GameCityApi.Controllers
{
    public class GoogleOAuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;

        public GoogleOAuthController(IAuthService authService, IConfiguration configuration)
        {
            _authService = authService;
            _configuration = configuration;
        }

        [HttpGet]
        public string Index()
        {
            return "Welcome to the Game City API Google OAuth Service";
        }

        [AllowAnonymous]
        [HttpPost("google")]
        public async Task<IActionResult> Google([FromBody] UserView userView)
        {
            try
            {
                var payload = GoogleJsonWebSignature.ValidateAsync(userView.TokenId, new GoogleJsonWebSignature.ValidationSettings()).Result;
                var user = await _authService.Authenticate(payload);

                var claims = new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,  user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JwtSecret"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(string.Empty,
                  string.Empty,
                  claims,
                  expires: DateTime.Now.AddSeconds(55 * 60),
                  signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return BadRequest();
        }
    }
}
