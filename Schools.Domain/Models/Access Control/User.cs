using School.Common.Auth;
using Schools.Domain.Abstractions;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models
{
    public class User : Person
    {
        public Guid RoleId { get; private set; }
        public virtual Role Role { get; private set; }

        public virtual Password Password { get; private set; }

        public DateTime? LastConnexionOn { get; private set; }


        public User()
        {

        }
        public User(string firstName, string lastName, Password password,string email, Guid roleId, Guid createdBy)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            RoleId = roleId;
            IsActive = true;
            CreatedBy = createdBy;
            CreatedOn = DateTime.UtcNow;
            Password = password;
        }

        public void EditBasicInfo(string firstName, string lastName, string address, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            AddressLine = address;
            Phone = phone;
        }

        public void ChangeEmail(string email)
        {
            Email = email;
        }

        //private void SetPassword(string password, IEncrypter encrypter)
        //{
        //    byte[] passwordSalt = encrypter.GetSalt();
        //    byte[] passwordHash = encrypter.GetHash(password, passwordSalt);

        //    PasswordSalt = passwordSalt;
        //    PasswordHash = passwordHash;
        //}

        //public bool VerifyPassword(string password, IEncrypter encrypter)
        //{
        //    return PasswordHash.Equals(encrypter.GetHash(password, PasswordSalt));
        //}

        public void SetLastConnexion()
        {
            LastConnexionOn = DateTime.UtcNow;
        }

        //public bool ChangePassword(string oldPassword, string newPassword, IEncrypter encrypter)
        //{
        //    bool validPassword = VerifyPassword(oldPassword, encrypter);
        //    if (validPassword)
        //    {
        //        SetPassword(newPassword, encrypter);
        //    }
        //    return validPassword;
        //}

    }
}
