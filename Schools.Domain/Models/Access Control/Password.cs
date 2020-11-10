using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class Password : ValueObject
    {
        public byte[] PasswordHash { get; private set; }
        public byte[] PasswordSalt { get; private set; }

        private static readonly int SaltSize = 40;
        private static readonly int DeriveBytesIterationsCount = 10000;

        public byte[] GetSalt()
        {
            var random = new Random();
            var saltBytes = new byte[SaltSize];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);

            return saltBytes;
        }

        public byte[] GetHash(string value, byte[] salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(value, salt, DeriveBytesIterationsCount);

            return pbkdf2.GetBytes(SaltSize);
        }

        public Password()
        {

        }
        private Password(string password)
        {
            byte[] passwordSalt = GetSalt();
            byte[] passwordHash = GetHash(password, passwordSalt);

            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
        }

        public static Result<Password> Create(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return Result.Failure<Password>("password should not be empty");

            if (password.Length > 200 && password.Length < 5)
                return Result.Failure<Password>("Password is too long");

            return Result.Success(new Password(password));
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PasswordHash;
            yield return PasswordSalt;
        }
    }
}
