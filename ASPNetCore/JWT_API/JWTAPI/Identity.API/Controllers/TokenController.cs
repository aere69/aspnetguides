using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Identity.API.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Identity.API.Controllers
{
    [Route("token")]
    public class TokenController : ControllerBase
    {
        // Sensitive const such as SecretKey, Issuer, and Audience have to be put
        // somewhere in the configuration.
        private const string SecretKey = "VerySecretAndLongKey-NeedMoreSymbolsHere-123";
        private const string Issuer = "IdentityServerIssuer";
        private const string Audience = "IdentityServerClient";
        private static readonly TimeSpan Lifetime = TimeSpan.FromMinutes(20);

        [HttpPost]
        public string Create([FromBody]TokenGenerationRequest request)
        {
            var claims = new List<Claim> { 
                new Claim(ClaimTypes.Email, request.Email),
                new Claim(ClaimTypes.Role, "Admin")
                //new Claim(ClaimTypes.Role, "Manager")
                //new Claim("IsOwner", "true")
            };

            var jwt = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: claims,
                expires: DateTime.UtcNow.Add(Lifetime),
                signingCredentials: CreateSignInCredentials());

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }

        private static SigningCredentials CreateSignInCredentials()
        {
            return new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey)),
                SecurityAlgorithms.HmacSha256);
        }
    }
}
