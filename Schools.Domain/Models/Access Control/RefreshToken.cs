using School.Common.Auth;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool Used { get; set; }

        public bool Invalidated { get; set; }
        public string JwtId { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
        public string Refresh_Token { get; set; }

        public RefreshToken()
        {
            Id = Guid.NewGuid();
            Token = GenerateRefreshToken();
        }
        public RefreshToken(JwtToken token)
        {
            UserId = token.UserId;
            Token = token.Token;
            CreationDate = DateTime.Now;
            ExpiryDate = token.ExpiryDate;
            Used = false;
            Invalidated = false;
            JwtId = token.JwtId;
            Refresh_Token = GenerateRefreshToken();

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



    }

}
