﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School.Common.Auth
{
    public class JwtHandler : IJwtHandler
    {
        private readonly JwtSecurityTokenHandler _jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        private readonly JwtOptions _options;
        private readonly SecurityKey _issuerSigningKey;
        private readonly SigningCredentials _signingCredentials;
        private readonly JwtHeader _jwtHeader;
        private readonly TokenValidationParameters _tokenValidationParameters;

        public JwtHandler(IOptions<JwtOptions> options)
        {
            _options = options.Value;
            _issuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKey));
            _signingCredentials = new SigningCredentials(_issuerSigningKey, SecurityAlgorithms.HmacSha256);
            _jwtHeader = new JwtHeader(_signingCredentials);
            _tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                //ValidIssuer = _options.Issuer,
                IssuerSigningKey = _issuerSigningKey,
                ValidateLifetime = false
            };
        }

        public JwtToken Create(Guid userId)
        {
            var nowUtc = DateTime.UtcNow;
            var expires = nowUtc.AddMinutes(_options.ExpiryMinutes);
            var centuryBegin = new DateTime(1970, 1, 1).ToUniversalTime();
            var exp = (long)(new TimeSpan(expires.Ticks - centuryBegin.Ticks).TotalSeconds);
            var now = (long)(new TimeSpan(nowUtc.Ticks - centuryBegin.Ticks).TotalSeconds);

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //{
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(JwtRegisteredClaimNames.Sub,userId.ToString())


        //}),
        //        Expires = DateTime.UtcNow.AddMinutes(100),


        //        SigningCredentials = _signingCredentials
        //    };

            var payload = new JwtPayload
            {
                {"sub", userId},
                //{"iss", _options.Issuer},
                {"iat", now},
                {"exp", exp},
                {"id", userId}
            };
            var jwt = new JwtSecurityToken(_jwtHeader, payload);
            var tokenHandler = new JwtSecurityTokenHandler();

            // var token = _jwtSecurityTokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
            var token = _jwtSecurityTokenHandler.WriteToken(jwt);
            return new JwtToken
            {
                Token = token,
                Expires = exp,
                CreatedOn = nowUtc,
                ExpiryDate = expires,
                JwtId = jwt.Id,
                UserId = userId
            };
        }

        public ClaimsPrincipal GetPrincipalClaims(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationParameters = _tokenValidationParameters.Clone();
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
