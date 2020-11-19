using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace School.Common.Auth
{
    public class JwtHandler : IJwtHandler
    {
        private readonly JwtOptions _jwtOptions;
        private readonly TokenValidationParameters _tokenValidationParameters;

        public JwtHandler(IOptions<JwtOptions> jwtOptions, TokenValidationParameters tokenValidationParameters)
        {
            _jwtOptions = jwtOptions.Value;
            _tokenValidationParameters = tokenValidationParameters;
        }
        public JwtToken Create(Guid userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtOptions.SecretKey);

            var nowUtc = DateTime.UtcNow;
            var expires = nowUtc.AddMinutes(_jwtOptions.ExpiryMinutes);
            var centuryBegin = new DateTime(1970, 1, 1).ToUniversalTime();
            var exp = (long)(new TimeSpan(expires.Ticks - centuryBegin.Ticks).TotalSeconds);
            var now = (long)(new TimeSpan(nowUtc.Ticks - centuryBegin.Ticks).TotalSeconds);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("id", userId.ToString())
                }),

                Expires = DateTime.UtcNow.AddMinutes(_jwtOptions.ExpiryMinutes),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return new JwtToken
            {
                Token = tokenString,
                TokenExpires = exp,
                CreatedOn = nowUtc,
                ExpiryDate = DateTime.UtcNow.AddDays(_jwtOptions.RefreshTokenExpiryDays),
                UserId = userId,
                JwtId = token.Id,
                RefreshToken = GenerateRefreshToken(),
                TokenExpiry = expires
            };
        }

        private static string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public bool IsTokenExpired(ClaimsPrincipal validatedToken)
        {
            var expiryDateInseconds =
               long.Parse(validatedToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

            var expiryDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            expiryDateTimeUtc = expiryDateTimeUtc.AddSeconds(expiryDateInseconds);

            if (expiryDateTimeUtc < DateTime.UtcNow)
            {
                return true;
            }
            return false;
        }

        public ClaimsPrincipal GetValidPrincipalClaim(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationParameters = _tokenValidationParameters.Clone();
                tokenValidationParameters.ValidateLifetime = false;
                if (tokenHandler.CanValidateToken)
                {
                    var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);
                    if (!IsJwtWithValidSecurityAlgorithm(validatedToken))
                    {
                        return null;
                    }

                    return principal;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        private bool IsJwtWithValidSecurityAlgorithm(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) &&
                   jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                       StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
