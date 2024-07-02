using AgendaApi.Application.UseCases.AuthenticationUseCases.Login;
using AgendaApi.Domain.Security;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace AgendaApi.Application.Shared.TokenServices
{
    public class TokenService
    {
        public static string GenerateAccessToken(LoginResponse response)
        {
            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration.Secrets.JwtPrivateKey);
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = GenerateClaims(response),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = credentials
            };
            var token = handler.CreateToken(tokenDescriptor);
            return handler.WriteToken(token);
        }

        public static string GenerateRefreshToken()
        {
            var randomBytes = new byte[128];
            using var randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }

        private static ClaimsIdentity GenerateClaims(LoginResponse response)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim("Id", response.Id.ToString()));
            foreach (var role in response.Roles)
            {
                claims.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }
    }
}
