using APIwithSQL.Models;
using APIwithSQL.SQLContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APIwithSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SqlDbContext _context;
        public AuthController(IConfiguration configuration, SqlDbContext context)
        {
            this._configuration = configuration;    
            this._context = context;
        }

        [HttpPost]
        [Route("Token")]
        public IActionResult userIsValid([FromBody]Authentication auth)
        {
            var userDetails = _context.TAT_Authentication_Mst.FirstOrDefault(x=>x.UserName == auth.UserName && x.Password ==auth.Password);
            if (userDetails != null)
            {
                var claims = new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,"APIUser"),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    new Claim("UserName",auth.UserName),
                    new Claim(ClaimTypes.Role, "Admin")

                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:SecretKey"]));
                var signIn = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                issuer: _configuration["JWTSettings:Issuer"],
                audience: _configuration["JWTSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signIn
            );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new { Token = tokenString });
            }
            return NotFound();
        }
    }
}
