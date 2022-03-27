using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class User : IdentityUser<string>
    {
        public User()
        {

        }

        public User(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            PasswordHash = user.PasswordHash;
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            EGN = user.EGN;
            PhoneNumber = user.PhoneNumber;
            Email = user.Email;
            HireDate = user.HireDate;
            IsActive = user.IsActive;
            IsAdmin = user.IsAdmin;
            FiredDate = FiredDate;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime? FiredDate { get; set; }


    }
}
